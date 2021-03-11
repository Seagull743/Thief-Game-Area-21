﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : InteractiveObject
{
   
    
    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
       
        GotKeyCard();
    }


    private void GotKeyCard()
    {
        Debug.Log("GotKey");
        
        gameObject.GetComponent<Collider>().enabled = false;
        StartCoroutine(DesroyObject());
    }

    IEnumerator DesroyObject()
    {
        yield return new WaitForFixedUpdate();
        Destroy(this.gameObject);

    }


}
