using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class loading : MonoBehaviour
{
    public Transform inputLoading;

    [SerializeField]
    private float initialValue;

    [SerializeField]
    private float ms;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(initialValue < 100)
        {
            initialValue += ms * Time.deltaTime;
            Debug.Log((int)initialValue);
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }

        inputLoading.GetComponent<Image>().fillAmount = initialValue / 100;
        
    }
}
