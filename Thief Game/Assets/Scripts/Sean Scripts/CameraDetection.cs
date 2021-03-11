using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetection : MonoBehaviour
{

    private float Timer;
    private bool timerStarter;
    public CountDownTimer CT;

    public Animator animator;
    
    void Start()
    {
        animator = GetComponentInParent<Animator>();
        Onanim();
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
    
    public void Onanim()
    {
         animator.SetBool("camOn", true);
    }

    public void offanim()
    {
        animator.SetBool("camoff", false);
        animator.SetBool("camOn", false);
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
