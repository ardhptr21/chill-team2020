using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{

    public void matahari()
    {
        SceneManager.LoadScene("Sun");
    }

    public void asteroid()
    {
        SceneManager.LoadScene("Asteroid");
    }

    public void bintang()
    {
        SceneManager.LoadScene("Stars");
    }

    public void bulan()
    {
        SceneManager.LoadScene("Moon");
    }

    public void planet()
    {
        SceneManager.LoadScene("Planet");
    }

    public void satelit()
    {
        SceneManager.LoadScene("Satellite");
    }

    public void back()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
