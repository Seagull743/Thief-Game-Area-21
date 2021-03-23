using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CameraDetection : MonoBehaviour
{   
   // private float Timer;
    private bool timerStarter;
    public Alarm alarm;

    public Transform CamRaycastPoint;
    public PlayerTargets targets;
    public LayerMask ConeVision;
    
    void Start()
    {
        targets = GM.instance.GetPlayerTargets();
    }
  
    // Update is called once per frame
    void Update()
    {   
     //  if(timerStarter == true)
     //  {
      //      Timer += Time.deltaTime;     
      // }
      // else if(timerStarter == false)
      // {
      //     Timer = 0;
           
     //  }

        //if(Timer >= 0.1)
       // {
            
            //CheckPlayer();
      //  }
   }


    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //timerStarter = true;
            CheckPlayer();
        }
    }
    

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timerStarter = false;
            //Debug.Log("Lost Vision");
        }
    }

    public void PlayAlarmSound()
    {
        
    }


    public void CheckPlayer()
    {
        //Debug.LogError("It's running");

        for(int i = 0; i < targets.playerTargetPoints.Length; i++)
        {
            Vector3 heading = targets.playerTargetPoints[i].position - CamRaycastPoint.position;
            float distance = heading.magnitude;
            Vector3 direction = heading / distance;

            RaycastHit hit;
            if (Physics.Raycast(CamRaycastPoint.position, direction, out hit, 30f, ~ConeVision))
            {
                GameObject hitObject = hit.transform.gameObject;
                Debug.DrawRay(CamRaycastPoint.position, direction * hit.distance, Color.red);

                if (hitObject.CompareTag("Player"))
                {
                    
                    alarm.GetComponent<Alarm>().StartSpinning();
                 
                }
            }
            else
            {
                Debug.DrawRay(CamRaycastPoint.transform.position, direction * distance, Color.white);
            }
        }       
       
    }

}
