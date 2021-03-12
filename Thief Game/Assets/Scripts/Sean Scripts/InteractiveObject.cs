using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
   
    public virtual void PlayerInteraction()
    {
        Debug.Log(gameObject.name);
    }

    void OnMouseOver()
    {
        if(Vector3.Distance(gameObject.transform.position, GM.instance.Playercam.position) <= PlayerRaycast.maxDistance)
        {
            GM.instance.InteractCross();
            GM.instance.SetCurrentObj(gameObject.GetComponent<InteractiveObject>());
        }
    }

    private void OnMouseExit()
    {
        GM.instance.Normalcross();
        GM.instance.RemoveCurrentObj(gameObject.GetComponent<InteractiveObject>());

    }

}
