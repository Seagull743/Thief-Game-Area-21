using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityTrigger : MonoBehaviour
{
    public SecurityDoor SD;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           if(SecurityDoor.DoorOpen == false)
            {
                SD.OpenDoor();
               
            }
           else if(SecurityDoor.DoorOpen == true)
            {
                SD.CloseDoor();
            }
        }
    }
}
