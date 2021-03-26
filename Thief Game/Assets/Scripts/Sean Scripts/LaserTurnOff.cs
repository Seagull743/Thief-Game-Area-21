using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTurnOff : InteractiveObject
{

    public GameObject[] lasers;
    public GameObject Spherecollider;
    public GM gm;
    public Animator anim;
    public GreenButton GB;
   



    void Start()
    {
        anim = GetComponentInChildren<Animator>();
       
    }


    public override void PlayerInteraction()
    {
        TurnOffLaser();
    }

    public void TurnOffLaser()
    {
        FindObjectOfType<AudioM>().Play("laserbutton");
        Spherecollider.GetComponent<Collider>().enabled = false;
        foreach (GameObject g in lasers) {
            g.SetActive(false);
        }
        //laser.SetActive(false);
        gm.GetComponent<GM>().Normalcross();
        anim.SetBool("redpressed", true);
        GB.GetComponent<GreenButton>().greenpressed();
        gameObject.GetComponent<Collider>().enabled = false;

        
    }


}