using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDoor : MonoBehaviour
{
    public Animator[] anim;
    public bool doorLocked = true;


    void Start()
    {
        anim = GetComponentsInChildren<Animator>();     
    }




    public void OpenDoor()
    {
        doorLocked = false;
        for (int i = 0; i < anim.Length; i++)
        {
            anim[i].SetBool("open", true);
        }

            
        
        
    }

}
