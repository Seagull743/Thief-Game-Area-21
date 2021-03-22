using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDoor : InteractiveObject
{
    public Animator anim;
    public Animator anim2;
    public bool doorLocked = true;

    public override void PlayerInteraction()
    {
        
        OpenDoor();
    }

        void Start()
    {
        anim = GetComponentInChildren<Animator>();
        anim2 = GetComponentInChildren<Animator>();
        
    }




    public void OpenDoor()
    {
        doorLocked = false;
        anim.SetBool("open", true);
        anim2.SetBool("open", true);
    }

}
