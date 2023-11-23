using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnStrat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btnStart = GetComponent<Button>();
        btnStart.onClick.AddListener(PrintStart);
        
    }

    public void PrintStart()
    {
        SceneManager.LoadScene("SelectYourCompeter");
        Debug.Log("start 버튼을 클릭했습니다");
    }

}