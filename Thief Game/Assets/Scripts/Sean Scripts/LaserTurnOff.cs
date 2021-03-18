using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTurnOff : InteractiveObject
{

    public GameObject laser;
    public GameObject Spherecollider;
    public GM gm;
    public Animator anim;
    public GreenButton GB;
   



    void Start()
    {
        anim = GetComponent<Animator>();
       
    }


    public override void PlayerInteraction()
    {
        TurnOffLaser();
    }

    public void TurnOffLaser()
    {
        Spherecollider.GetComponent<Collider>().enabled = false;
        laser.SetActive(false);
        gm.GetComponent<GM>().Normalcross();
        anim.SetBool("redpressed", true);
        GB.GetComponent<GreenButton>().greenpressed();

        
    }


}