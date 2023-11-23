using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelHhw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button YesButton = GetComponent<Button>();
        YesButton.onClick.AddListener(PrintHhw);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PrintHhw()
    {
        SceneManager.LoadScene("Hhw");
    }

}