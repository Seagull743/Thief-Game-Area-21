﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{

    public float RotateSpeed;
    public GameObject light1;
    public GameObject light2;
    public bool Spotted = false;

    //Cam Lights
    public GameObject camlight1;
    public GameObject camelight2;

     void Start()
    {
        light1.SetActive(false);
        light2.SetActive(false);
    }

    void Update()
    {
        if (Spotted)
        {
            transform.Rotate(new Vector3(0f, RotateSpeed, 0f) * Time.deltaTime);
        }
      
    }

    public void StartSpinning()
    {
        Spotted = true;
        light1.SetActive(true);
        light2.SetActive(true);
        camlight1.SetActive(false);
        camelight2.SetActive(false);
    }


}