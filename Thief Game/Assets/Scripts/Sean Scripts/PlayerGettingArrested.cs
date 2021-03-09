using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGettingArrested : MonoBehaviour
{
    public Animator anim;
    public Cameralook Cl;
    public PlayerMovement PM;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    public void DoAnim()
    {
        anim.SetBool("isArrested", true);
        Cl.GetComponent<Cameralook>().enabled = false;
        PM.GetComponent<PlayerMovement>().enabled = false;
    }

    
}
