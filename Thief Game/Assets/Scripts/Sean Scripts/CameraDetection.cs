using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetection : MonoBehaviour
{

    private float Timer;
    private bool timerStarter;
    public CountDownTimer CT;

    
    void Start()
    {
    }
  
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
           
       }

        if(Timer >= 1)
        {
            Debug.Log("You have been caught");
            CT.GetComponent<CountDownTimer>().Spotted();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            timerStarter = true;
        }
    }
    

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timerStarter = false;
            Debug.Log("Lost Vision");
        }
    }



}
