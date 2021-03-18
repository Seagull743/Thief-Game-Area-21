using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : InteractiveObject
{
    public OfficeDoor OD;
    public GameObject greenlight;
    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
        UnlockDoor();
    }


    public void UnlockDoor()
    {   
        OD.GetComponent<OfficeDoor>().OpenDoor();
        gameObject.GetComponent<Collider>().enabled = false;
        greenlight.SetActive(true);
    }


}