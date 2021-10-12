using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllSceneControl : MonoBehaviour
{
    // button info control
    public GameObject info;
    public GameObject buttonInfo1;
    public GameObject buttonInfo2;

    // button text to speech control
    public GameObject buttonTts1;
    public GameObject buttonTts2;

    // audio source
    public AudioSource audioTts;

    // Start is called before the first frame update
    void Start()
    {
        infoButton2();
        buttonTts2.SetActive(false);
        audioTts.Stop();
    }

    public void infoButton1()
    {
        info.SetActive(true);
        buttonInfo1.SetActive(false);
        buttonInfo2.SetActive(true);
    }

    public void infoButton2()
    {
        info.SetActive(false);
        buttonInfo1.SetActive(true);
        buttonInfo2.SetActive(false);
    }

    public void ttsButton1()
    {
        audioTts.Play();
        buttonTts2.SetActive(true);
    }

    public void ttsButton2()
    {
        audioTts.Stop();
        buttonTts2.SetActive(false);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("MainMenu2");
    }
}
