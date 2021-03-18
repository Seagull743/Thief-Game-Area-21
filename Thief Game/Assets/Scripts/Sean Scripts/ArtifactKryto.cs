using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactKryto : InteractiveObject
{
  
  public GM gm;
    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
        AddScore();

    }

    public void AddScore()
    {
      GM.theScore  += 1;
      gm.GetComponent<GM>().kryptoTick();
      Destroy(gameObject);
    }

}