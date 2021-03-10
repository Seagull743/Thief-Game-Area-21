using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{

    public static GM instance;
    public GameObject player;
    
    
    [SerializeField]
    private GameObject interactcross;
    [SerializeField]
    private GameObject normalcross;



    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Normalcross()
    {
        interactcross.SetActive(false);
        normalcross.SetActive(true);
    }

    public void InteractCross()
    {

        interactcross.SetActive(true);
        normalcross.SetActive(false);
    }



}
