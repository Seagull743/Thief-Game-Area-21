using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectArtifact : InteractiveObject
{
    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
        AddScore();

    }



    public void AddScore()
    {
      GM.theScore  += 1;
      Destroy(gameObject);
    }

}