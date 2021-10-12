using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScript : MonoBehaviour
{
    public GameObject infoMercury;
    public GameObject infoVenus;
    public GameObject infoEarth;
    public GameObject infoMars;
    public GameObject infoJupiter;
    public GameObject infoSaturn;
    public GameObject infoUranus;
    public GameObject infoNeptune;

    public GameObject button1;
    public GameObject button2;

    // Start is called before the first frame update
    void Start()
    {
        infoButtonOff();
        destroyButton2();


    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void infoButton()
    {
        infoMercury.SetActive(true);
        infoVenus.SetActive(true);
        infoEarth.SetActive(true);
        infoMars.SetActive(true);
        infoJupiter.SetActive(true);
        infoSaturn.SetActive(true);
        infoUranus.SetActive(true);
        infoNeptune.SetActive(true);
    }

    public void infoButtonOff()
    {
        infoMercury.SetActive(false);
        infoVenus.SetActive(false);
        infoEarth.SetActive(false);
        infoMars.SetActive(false);
        infoJupiter.SetActive(false);
        infoSaturn.SetActive(false);
        infoUranus.SetActive(false);
        infoNeptune.SetActive(false);
    }

    public void destroyButton1()
    {
        button1.SetActive(false);
        button2.SetActive(true);
    }

    public void destroyButton2()
    {
        button1.SetActive(true);
        button2.SetActive(false);
    }
}
