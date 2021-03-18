using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
   
    public virtual void PlayerInteraction() { }

   
    
   
    
    // void OnMouseOver()
    //{
    //    Debug.Log(Vector3.Distance(gameObject.transform.position, GM.instance.Playercam.position));
        
     //   if(Vector3.Distance(gameObject.transform.position, GM.instance.Playercam.position) <= PlayerRaycast.maxDistance)
    //    {
    //        GM.instance.InteractCross();
    //        GM.instance.SetCurrentObj(gameObject.GetComponent<InteractiveObject>());
   //     }
   // }

   // private void OnMouseExit()
   // {
   //     GM.instance.Normalcross();
   //     GM.instance.RemoveCurrentObj(gameObject.GetComponent<InteractiveObject>());

   // }

}
