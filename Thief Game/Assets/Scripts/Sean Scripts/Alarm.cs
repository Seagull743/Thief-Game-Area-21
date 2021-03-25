using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{

    public float RotateSpeed;
    public GameObject light1;
    public GameObject light2;
    public static bool Spotted = false;


    //Cam Lights
    public GameObject camlight1;
    public GameObject camelight2;
   

    public CountDownTimer CDT;
    public GameObject escapetext;

     void Start()
    {
        light1.SetActive(false);
        light2.SetActive(false);
        escapetext.SetActive(false);
       
    }

    void Update()
    {
        if (Spotted)
        {
            transform.Rotate(new Vector3(0f, RotateSpeed, 0f) * Time.deltaTime);
        }
      
    }

    public void spinning()
    {
        Spotted = true;
        light1.SetActive(true);
        light2.SetActive(true);
        CDT.GetComponent<CountDownTimer>().Spotted();
        FindObjectOfType<AudioManager>().Play("Alarm");
        escapetext.SetActive(true);

    }


    public void StartSpinning()
    {    
        camlight1.SetActive(false);
        camelight2.SetActive(false);
        Invoke("spinning", 2.0f);

        
    }


}
