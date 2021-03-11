using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBox : MonoBehaviour
{
   
   public Animator anim;
   public CameraTurnOff CTO;
   public CameraDetection cameradetection;
   
   
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        
    }

    

    public void TurnOffBox()
    {
        anim.SetBool("turnoff", true);
        CTO.GetComponent<CameraTurnOff>().CamTurnOff();
        cameradetection.GetComponent<CameraDetection>().offanim();
    }

}
