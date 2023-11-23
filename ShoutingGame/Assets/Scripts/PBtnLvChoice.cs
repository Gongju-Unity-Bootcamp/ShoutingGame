using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PBtnLvChoice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btnChoice = GetComponent<Button>();
        btnChoice.onClick.AddListener(ChangeScene);
    }

    public void ChangeScene()
    {

        SceneManager.LoadScene("SelectYourCompeter");
        Debug.Log("레벨 선택 버튼을 눌렀습니다.");
    }
}
