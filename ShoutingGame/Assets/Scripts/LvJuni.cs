using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class LvJuni : MonoBehaviour
{

    SerialPort serialPort = new SerialPort("COM4", 9600);
    private float timer = 53f;
    private bool isTimerRunning = true;


    public Text timerText;

    void Start()
    {
        serialPort.Open();
    }

    void Update()
    {
        if (isTimerRunning)
        {
            UpdateTimer();
            UpdateSensor();
        }
    }

    void UpdateTimer()
    {

        timer -= Time.deltaTime;

        timerText.text = $"TIME \n {Mathf.Ceil(timer)}";

        if (timer <= 0)
        {
            ChangeScene("GameOver");
        }
    }

    void UpdateSensor()
    {
        if (serialPort.IsOpen)
        {
            try
            {
                string input = serialPort.ReadLine();
                int data = Convert.ToInt32(input);

                Debug.Log("데시벨 값: " + input);
                GameObject.Find("TxtScore").GetComponent<Text>().text = $"SCORE \n {input}";

                if ((data >= 650) && (data <= 700))
                {
                    SceneManager.LoadScene("LevelClear");
                    Debug.Log("씬 전환 성공");
                }
            }
            catch
            {
                Debug.Log("오류 발생");
            }
        }
    }

    void ChangeScene(string sceneName)
    {
        isTimerRunning = false;
        SceneManager.LoadScene(sceneName);
    }

    public void CloseCommunication()
    {
        if (serialPort.IsOpen)
        {
            serialPort.Close();
        }
    }
}
