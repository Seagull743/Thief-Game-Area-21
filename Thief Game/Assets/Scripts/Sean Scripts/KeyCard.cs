﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : InteractiveObject
{
   
    public GameObject lockedCollider;
    public override void PlayerInteraction()
    {     
        GotKeyCard();
    }


    private void GotKeyCard()
    {
        Debug.Log("GotKey");
        lockedCollider.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        StartCoroutine(DesroyObject());
    }

    IEnumerator DesroyObject()
    {
        yield return new WaitForFixedUpdate();
        Destroy(this.gameObject);

    }


}
