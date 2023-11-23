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
            Debug.Log("pŰ�� ���Ƚ��ϴ�");
            SetPanelActive(true);
            PauseGame();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("escŰ�� ���Ƚ��ϴ�");
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
        Debug.Log("������ �ߴ��մϴ�");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        Debug.Log("������ �̾ �����մϴ�");
    }
}
