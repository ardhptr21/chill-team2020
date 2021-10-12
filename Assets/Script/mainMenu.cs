using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject credit;
    public GameObject profile;
    public AudioSource uiSound;
    public GameObject button1;
    public GameObject button2;
    // Start is called before the first frame update
    void Start()
    {
        uiSound.Play();
        menu.SetActive(true);
        credit.SetActive(false);
        profile.SetActive(false);
        button2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void creditButton()
    {
        menu.SetActive(true);
        credit.SetActive(true);
        profile.SetActive(false);
    }

    public void profiles()
    {
        menu.SetActive(true);
        credit.SetActive(false);
        profile.SetActive(true);
    }
    public void backButton()
    {
        menu.SetActive(true);
        credit.SetActive(false);
        profile.SetActive(false);
    }

    public void exit()
    {
        Application.Quit();
    }

    public void NextMainMenu()
    {
        SceneManager.LoadScene("MainMenu2");
    }

    public void destroyButton1()
    {
        uiSound.Pause();
        button1.SetActive(false);
        button2.SetActive(true);
    }

    public void destroyButton2()
    {
        uiSound.Play();
        button1.SetActive(true);
        button2.SetActive(false);
    }
}
