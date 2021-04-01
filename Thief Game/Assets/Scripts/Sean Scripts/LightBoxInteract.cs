using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBoxInteract : InteractiveObject
{
   
    public LightBox LB;
    public Animator anim;
    public GM gm;

    public GameObject[] bluewire;
    public GameObject[] blackwire;
 

    void Start()
    {
        anim.GetComponent<Animator>();

        foreach (GameObject g in blackwire)
        {
            g.SetActive(false);
        }


        foreach (GameObject g in bluewire)
        {
            g.SetActive(true);
        }

    }


    public override void PlayerInteraction()
    {
        anim.SetBool("turnoff", true);
        FindObjectOfType<AudioM>().Play("LightSwitch");
        LB.GetComponent<LightBox>().TurnOffBox();
        gm.GetComponent<GM>().Normalcross();

        foreach (GameObject g in blackwire)
        {
            g.SetActive(true);
        }

        foreach (GameObject g in bluewire)
        {
            g.SetActive(false);
        }


    }

}
