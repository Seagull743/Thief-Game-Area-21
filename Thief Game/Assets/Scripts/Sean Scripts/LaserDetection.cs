using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDetection : MonoBehaviour
{

    public CountDownTimer CDT;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CDT.GetComponent<CountDownTimer>().Spotted();
        }
    }


}
