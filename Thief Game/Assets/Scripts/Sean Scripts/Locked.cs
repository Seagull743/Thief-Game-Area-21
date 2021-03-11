using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locked : InteractiveObject
{
    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
        LockedDoor();
    }

    public void LockedDoor()
    {

    }

}
