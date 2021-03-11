using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDoor : InteractiveObject
{
    public Animator anim;
    public bool doorLocked = true;

    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
        OpenDoor();

    }

        void Start()
    {
        anim = GetComponent<Animator>();
    }




    public void OpenDoor()
    {
        doorLocked = false;
        anim.SetBool("opened", true);
    }

}
