using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTurnOff : InteractiveObject
{

    public GameObject laser;
    public GameObject Spherecollider;

    public override void PlayerInteraction()
    {
        TurnOffLaser();
    }

    public void TurnOffLaser()
    {
        Spherecollider.GetComponent<Collider>().enabled = false;
        laser.SetActive(false);
        
    }


}