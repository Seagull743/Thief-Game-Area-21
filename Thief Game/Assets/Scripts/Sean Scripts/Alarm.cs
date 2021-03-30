using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{

    public float RotateSpeed;
    public GameObject light1;
    public GameObject light2;
    public GameObject[] LightBeam1;
    public GameObject[] LightBeam2;
    public GameObject[] LightBeamAnim;

    public static bool Spotted = false;


    //Cam Lights
    
   

    public CountDownTimer CDT;
    public GameObject escapetext;

     void Start()
    {
        light1.SetActive(false);
        light2.SetActive(false);
        escapetext.SetActive(false);
        
        foreach(GameObject g in LightBeam2)
        {
            g.SetActive(false);
        }

        foreach (GameObject g in LightBeamAnim)
        {
            g.GetComponent<Animator>();
            g.GetComponent<Animator>().enabled = true;
        }
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
        FindObjectOfType<AudioM>().Play("Alarm");
        escapetext.SetActive(true);

    }


    public void StartSpinning()
    {
        // add for each loop
        foreach (GameObject g in LightBeam1)
        {
            g.SetActive(false);
        }

        foreach(GameObject g in LightBeam2)
        {
            g.SetActive(true);
        }

        foreach (GameObject g in LightBeamAnim)
        {
            g.GetComponent<Animator>().enabled = false;
        }

        Invoke("spinning", 2.0f);

        
    }


}
