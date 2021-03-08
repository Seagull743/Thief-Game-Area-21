using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetection : MonoBehaviour
{

    private float Timer;
    private bool timerStarter;
    
    // Update is called once per frame
    void Update()
    {
       
      
       
       if(timerStarter == true)
       {
            Timer += Time.deltaTime;     
       }
       else if(timerStarter == false)
       {
           Timer = 0;
           Debug.Log("You have been Reset");
       }

        if(Timer >= 2)
        {
            Debug.Log("You have been caught");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            timerStarter = true;
        }
        else
        {
            timerStarter = false;
        }   
    }

  


}
