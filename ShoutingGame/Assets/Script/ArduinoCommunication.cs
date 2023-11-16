using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;
using System;

public class ArduinoCommunication : MonoBehaviour
{

    SerialPort serialPort = new SerialPort("COM3", 9600);  //serial port open

    // Start is called before the first frame update
    void Start()
    {
        serialPort.Open();
    }

    // Update is called once per frame
    void Update()
    {
       if(serialPort.IsOpen)
        {
            try
            {
                string value = serialPort.ReadLine(); // 아두이노에서 센서 값 받음
                Debug.Log("데시벨 값:" + value);

                GameObject.Find("Score").GetComponent<Text>().text = ($"SOCRE\t{value}");
              
            }

            catch 
            {
                Debug.Log("오류발생");
            }
        }

       void OnApplicationQuit()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
