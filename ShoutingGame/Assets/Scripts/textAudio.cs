using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textAudio : MonoBehaviour
{

    public Image imgObjSinger;
    public Image imgObjCat;

    public Text textObject;

    public AudioClip audioClip;
    private AudioSource audioSource;

    private Color defaultSingerColor;
    private Color defaultCatColor;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        defaultSingerColor = imgObjSinger.color;
        defaultCatColor = imgObjCat.color;

        InvokeRepeating("UpdateText", 1f, 1f); // 1�ʸ��� UpdateText �޼ҵ� ȣ��
        Invoke("PlayAudio", 3f); // 3�� �Ŀ� PlayAudio �޼ҵ� ȣ��
        Invoke("HideText", 3f); // 3�� �Ŀ� HideText �޼ҵ� ȣ��

    }

    private void Update()
    {
        float darkeningFactor = 0.9f;

        if (audioSource.isPlaying)
        {
         
            imgObjSinger.color = defaultSingerColor;
            //imgObjCat.color = Color.black;
            imgObjCat.color = new Color(1, 1, 1, 1 - darkeningFactor);

        }

        else
        {
            imgObjSinger.color = new Color(1, 1, 1, 1 - darkeningFactor);
            imgObjCat.color = defaultCatColor;
        }


        if ((Input.GetKeyUp(KeyCode.P)) && (audioSource.isPlaying))
        {
            PauseAudio();
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnPauseAudio();
        }
    }

    void UpdateText()
    {
        int count = 3 - Mathf.FloorToInt(Time.time);

        if (count > 0)
        {
            textObject.text = count.ToString();
        }

        else
        {
            textObject.text = "����";
        }
    }

    void PlayAudio()
    {
        audioSource.clip = audioClip;
        audioSource.Play();

    }

    void PauseAudio()
    {
        audioSource.Pause();
    }

    void UnPauseAudio()
    {
        audioSource.UnPause();
    }

    void HideText()
    {
        textObject.enabled = false;
    }
}

