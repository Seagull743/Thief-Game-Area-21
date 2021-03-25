using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDetection : MonoBehaviour
{

    public Alarm alarm;

    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            alarm.GetComponent<Alarm>().StartSpinning();
        }
    }



    public void PlaySound()
    {
       
    }

}
