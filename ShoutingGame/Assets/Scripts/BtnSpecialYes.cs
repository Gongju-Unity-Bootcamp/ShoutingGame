using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnSpecialYes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btnYes = GetComponent<Button>();
        btnYes.onClick.AddListener(PrintYes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintYes()
    {
        SceneManager.LoadScene("Vitas");
        Debug.Log("yes 버튼을 클릭했습니다");
    }
}
