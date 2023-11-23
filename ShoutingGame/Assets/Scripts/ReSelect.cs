using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReSelect : MonoBehaviour
{
    public float delay;

    void Start()
    {
        Invoke("LoadNextScene", delay);
    }

    void Update()
    {
        
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("SelectYourCompeter");
    }
}
