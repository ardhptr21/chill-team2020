using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlanet : MonoBehaviour
{
    public AudioSource mercury;
    public AudioSource venus;
    public AudioSource earth;
    public AudioSource mars;
    public AudioSource jupiter;
    public AudioSource saturn;
    public AudioSource uranus;
    public AudioSource neptune;

    public AudioSource infoMercury;
    public AudioSource infoVenus;
    public AudioSource infoEarth;
    public AudioSource infoMars;
    public AudioSource infoJupiter;
    public AudioSource infoSaturn;
    public AudioSource infoUranus;
    public AudioSource infoNeptune;

    public GameObject muteButton;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;


    // Start is called before the first frame update
    void Start()
    {
        mercury.Stop();
        venus.Stop();
        earth.Stop();
        mars.Stop();
        jupiter.Stop();
        saturn.Stop();
        uranus.Stop();
        neptune.Stop();

        infoMercury.Stop();
        infoVenus.Stop();
        infoEarth.Stop();
        infoMars.Stop();
        infoJupiter.Stop();
        infoSaturn.Stop();
        infoUranus.Stop();
        infoNeptune.Stop();

        muteButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mercuryAudio()
    {
        mercury.PlayOneShot(mercury.clip);
    }

    public void venusAudio()
    {
        venus.PlayOneShot(venus.clip);
    }

    public void earthAudio()
    {
        earth.PlayOneShot(earth.clip);
    }

    public void marsAudio()
    {
        mars.PlayOneShot(mars.clip);
    }

    public void jupiterAudio()
    {
        jupiter.PlayOneShot(jupiter.clip);
    }

    public void saturnAudio()
    {
        saturn.PlayOneShot(saturn.clip);
    }

    public void uranusAudio()
    {
        uranus.PlayOneShot(uranus.clip);
    }

    public void neptuneAudio()
    {
        neptune.PlayOneShot(neptune.clip);
    }

    public void infoAudio1()
    {
        muteButton.SetActive(true);
        infoMercury.Play();
    }

    public void infoAudio2()
    {
        muteButton.SetActive(true);
        infoVenus.Play();
    }

    public void infoAudio3()
    {
        muteButton.SetActive(true);
        infoEarth.Play();
    }

    public void infoAudio4()
    {
        muteButton.SetActive(true);
        infoMars.Play();
    }

    public void infoAudio5()
    {
        muteButton.SetActive(true);
        infoJupiter.Play();
    }

    public void infoAudio6()
    {
        muteButton.SetActive(true);
        infoSaturn.Play();
    }

    public void infoAudio7()
    {
        muteButton.SetActive(true);
        infoUranus.Play();
    }

    public void infoAudio8()
    {
        muteButton.SetActive(true);
        infoNeptune.Play();
    }

    public void buttonMute()
    {
        infoMercury.Stop();
        infoVenus.Stop();
        infoEarth.Stop();
        infoMars.Stop();
        infoJupiter.Stop();
        infoSaturn.Stop();
        infoUranus.Stop();
        infoNeptune.Stop();
        muteButton.SetActive(false);
    }
}
