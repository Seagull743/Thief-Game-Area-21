using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : InteractiveObject
{
   
    public GameObject lockedCollider;
    public GM gm;
    public override void PlayerInteraction()
    {     
        GotKeyCard();
    }


    private void GotKeyCard()
    {
        Debug.Log("GotKey");
        lockedCollider.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        gm.GetComponent<GM>().Normalcross();
        Destroy(this.gameObject);
    }

   


}
