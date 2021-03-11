using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBoxInteract : InteractiveObject
{
   
   public LightBox LB;
   
    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
        LB.GetComponent<LightBox>().TurnOffBox();
    }

}
