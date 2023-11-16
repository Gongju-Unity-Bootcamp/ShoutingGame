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
                string value = serialPort.ReadLine(); // �Ƶ��̳뿡�� ���� �� ����
                Debug.Log("���ú� ��:" + value);

                GameObject.Find("Score").GetComponent<Text>().text = ($"SOCRE\t{value}");
              
            }

            catch 
            {
                Debug.Log("�����߻�");
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
