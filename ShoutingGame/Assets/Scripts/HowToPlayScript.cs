using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HowToButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button HowToButton = GetComponent<Button>();
        HowToButton.onClick.AddListener(PrintHowTo);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PrintHowTo()
    {
        SceneManager.LoadScene("HowToPlay");
        Debug.Log("How To Play 버튼을 클릭했습니다");
    }

}