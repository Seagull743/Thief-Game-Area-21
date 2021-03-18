using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBoxInteract : InteractiveObject
{
   
    public LightBox LB;
    public Animator anim;
    public GM gm;


    void Start()
    {
        anim.GetComponent<Animator>();
    }


    public override void PlayerInteraction()
    {
        anim.SetBool("turnoff", true);
        LB.GetComponent<LightBox>().TurnOffBox();
        gm.GetComponent<GM>().Normalcross();    
    }

}
