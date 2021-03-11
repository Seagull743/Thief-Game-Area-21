using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locked : InteractiveObject
{
    
    public GM gamemanager;
    
    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
        gamemanager.LockedDoor();       
    }

   





}
