using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBoxInteract : InteractiveObject
{
   
   public LightBox LB;
    public Animator anim;


    void Start()
    {
        anim.GetComponent<Animator>();
    }




    public override void PlayerInteraction()
    {
        
        base.PlayerInteraction();
        anim.SetBool("turnoff", true);
        LB.GetComponent<LightBox>().TurnOffBox();
    }

}
