using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : InteractiveObject
{
    public OfficeDoor OD;
    public GameObject greenlight;
    public GameObject orangecolor;
    public GameObject Collider;

    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
        UnlockDoor();
    }


    public void UnlockDoor()
    {   
        OD.GetComponent<OfficeDoor>().OpenDoor();
        gameObject.GetComponent<Collider>().enabled = false;
        orangecolor.SetActive(false);
        FindObjectOfType<AudioManager>().Play("KeyPad");
        greenlight.SetActive(true);
        Collider.GetComponent<BoxCollider>().enabled = false;     
    }


}