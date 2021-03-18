using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBox : MonoBehaviour
{
   
 
   public CameraTurnOff CTO;
   
   
   
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    

    public void TurnOffBox()
    {
       
        CTO.GetComponent<CameraTurnOff>().CamTurnOff();
 
    }

}
