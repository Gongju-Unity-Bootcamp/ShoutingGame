using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnSpecialNo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btnNo = GetComponent<Button>();
        btnNo.onClick.AddListener(PrintNo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintNo()
    {
        SceneManager.LoadScene("Nevertheless");
        Debug.Log("No 버튼을 클릭했습니다");
    }
}
