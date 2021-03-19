using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityDoor : MonoBehaviour
{

    public Animator anim;
    public static bool DoorOpen;

    // Start is called before the first frame update

    void Start()
    {
        anim = GetComponent<Animator>();
    }


  

    public void OpenDoor()
    {
        anim.SetBool("open", true);
        DoorOpen = true;
    }

    public void CloseDoor()
    {    
        anim.SetBool("open", false);
        DoorOpen = false;
    }

}
