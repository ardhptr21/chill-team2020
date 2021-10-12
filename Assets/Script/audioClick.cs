using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioClick : MonoBehaviour
{
    public AudioSource buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        buttonClick.Stop();
    }

    public void click()
    {
        buttonClick.PlayOneShot(buttonClick.clip);
    }

}
