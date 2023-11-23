using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelKjs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button YesButton = GetComponent<Button>();
        YesButton.onClick.AddListener(PrintKjs);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PrintKjs()
    {
        SceneManager.LoadScene("Kjs");
    }

}