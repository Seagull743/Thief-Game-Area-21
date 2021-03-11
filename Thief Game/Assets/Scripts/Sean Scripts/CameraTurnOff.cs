using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurnOff : MonoBehaviour
{
    
    public Animator anim;
    public GameObject lightSource1;
 
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        

    }

    public void CamTurnOff()
    {
        anim.SetBool("turnoff", true);
        anim.SetBool("camOn", false);
        lightSource1.SetActive(false);
       
    }


}
