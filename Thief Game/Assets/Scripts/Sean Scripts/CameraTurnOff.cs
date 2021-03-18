using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurnOff : MonoBehaviour
{

    public GameObject anim;
    public GameObject lightSource1;
    public GameObject Boxcollider;
 
    
    
    // Start is called before the first frame update
    void Start()
    {
      
       
    }

    public void CamTurnOff()
    {
        anim.GetComponent<Animator>().enabled = false;
        Boxcollider.GetComponent<BoxCollider>().enabled = false;
        lightSource1.SetActive(false);
       
    }


}
