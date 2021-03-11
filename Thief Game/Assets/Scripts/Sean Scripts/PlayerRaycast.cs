using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{

    public Transform playerCam;

    public static float maxDistance = 3f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractiveObject i = GM.instance.GetCurrentInteractiveObj();
            if(null != i)
            {
                i.PlayerInteraction();
            }
        }

    }

    public void Pressed()
    {
        RaycastHit hit;

        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, maxDistance))
        {

            GameObject hitObject = hit.transform.gameObject;
            Debug.Log(hitObject.name);

            if (hitObject.GetComponent<InteractiveObject>())
            {
                hitObject.GetComponent<InteractiveObject>().PlayerInteraction();
            }
        
        
        }




    }
}
