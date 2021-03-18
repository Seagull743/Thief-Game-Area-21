using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locked : InteractiveObject
{
    
    public GM gamemanager;
    public GameObject RedColor;
    public override void PlayerInteraction()
    {
        base.PlayerInteraction();
        gamemanager.LockedDoor();       
        StartCoroutine(RedFlash());
    }


    IEnumerator RedFlash()
    {
        RedColor.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        RedColor.SetActive(false);
    }

   





}
