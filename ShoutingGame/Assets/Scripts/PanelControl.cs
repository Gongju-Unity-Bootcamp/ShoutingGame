using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControl : MonoBehaviour
{
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        SetPanelActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("p키가 눌렸습니다");
            SetPanelActive(true);
            PauseGame();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("esc키가 눌렸습니다");
            SetPanelActive(false);
            ResumeGame();
        }
    }


    void SetPanelActive(bool isActive)
    {
        panel.SetActive(isActive);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        Debug.Log("게임을 중단합니다");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        Debug.Log("게임을 이어서 시작합니다");
    }
}
