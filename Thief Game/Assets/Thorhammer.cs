using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorhammer : InteractiveObject
{
    public GM gm;

    public override void PlayerInteraction()
    {
        gm.GetComponent<GM>().thortext();
    }
       

}
