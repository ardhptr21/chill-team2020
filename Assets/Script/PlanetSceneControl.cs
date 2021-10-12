using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetSceneControl : MonoBehaviour
{
    public GameObject mercury;
    public GameObject venus;
    public GameObject earth;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public GameObject neptune;


    // Start is called before the first frame update
    void Start()
    {
        mercury.SetActive(true);
        venus.SetActive(false);
        earth.SetActive(false);
        mars.SetActive(false);
        jupiter.SetActive(false);
        saturn.SetActive(false);
        uranus.SetActive(false);
        neptune.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void button1()
    {
        mercury.SetActive(true);
        venus.SetActive(false);
        earth.SetActive(false);
        mars.SetActive(false);
        jupiter.SetActive(false);
        saturn.SetActive(false);
        uranus.SetActive(false);
        neptune.SetActive(false);
    }

    public void button2()
    {
        mercury.SetActive(false);
        venus.SetActive(true);
        earth.SetActive(false);
        mars.SetActive(false);
        jupiter.SetActive(false);
        saturn.SetActive(false);
        uranus.SetActive(false);
        neptune.SetActive(false);
    }

    public void button3()
    {
        mercury.SetActive(false);
        venus.SetActive(false);
        earth.SetActive(true);
        mars.SetActive(false);
        jupiter.SetActive(false);
        saturn.SetActive(false);
        uranus.SetActive(false);
        neptune.SetActive(false);
    }

    public void button4()
    {
        mercury.SetActive(false);
        venus.SetActive(false);
        earth.SetActive(false);
        mars.SetActive(true);
        jupiter.SetActive(false);
        saturn.SetActive(false);
        uranus.SetActive(false);
        neptune.SetActive(false);
    }

    public void button5()
    {
        mercury.SetActive(false);
        venus.SetActive(false);
        earth.SetActive(false);
        mars.SetActive(false);
        jupiter.SetActive(true);
        saturn.SetActive(false);
        uranus.SetActive(false);
        neptune.SetActive(false);
    }

    public void button6()
    {
        mercury.SetActive(false);
        venus.SetActive(false);
        earth.SetActive(false);
        mars.SetActive(false);
        jupiter.SetActive(false);
        saturn.SetActive(true);
        uranus.SetActive(false);
        neptune.SetActive(false);
    }

    public void button7()
    {
        mercury.SetActive(false);
        venus.SetActive(false);
        earth.SetActive(false);
        mars.SetActive(false);
        jupiter.SetActive(false);
        saturn.SetActive(false);
        uranus.SetActive(true);
        neptune.SetActive(false);
    }

    public void button8()
    {
        mercury.SetActive(false);
        venus.SetActive(false);
        earth.SetActive(false);
        mars.SetActive(false);
        jupiter.SetActive(false);
        saturn.SetActive(false);
        uranus.SetActive(false);
        neptune.SetActive(true);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("MainMenu2");
    }


}
