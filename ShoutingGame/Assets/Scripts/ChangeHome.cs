using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeHome : MonoBehaviour
{

    public float delay;

    void Start()
    {
        Invoke("PrintHome", delay);
    }

    // Update is called once per frame
    void PrintHome()
    {
        SceneManager.LoadScene("Intro");
    }
}
