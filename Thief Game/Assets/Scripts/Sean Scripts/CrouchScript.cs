using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    
    public CharacterController playerCol;
    private float originalHeight;
    public float reducedHeight;

    public static bool isCrouching;

    
    // Start is called before the first frame update
    void Start()
    {
        playerCol.GetComponent<CharacterController>();
        originalHeight = playerCol.height;
        isCrouching = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            Crouch();
        }
        else if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            unCrouch();
        }

    }

    private void Crouch()
    {
        playerCol.height = reducedHeight;
        isCrouching = true;

    }

    public  void unCrouch()
    {
        playerCol.height = originalHeight;
        isCrouching = false;
    }
}
