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
    [SerializeField] private InteractiveObject currentObj;



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

        interactcross.SetActive(false);
        normalcross.SetActive(true);
    
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

    public void SetCurrentObj(InteractiveObject i)
    {
        currentObj = i;
    }

    public void RemoveCurrentObj(InteractiveObject i)
    {
        if(currentObj == i)
        {
            currentObj = null;
        }
    }

    public InteractiveObject GetCurrentInteractiveObj()
    {
        return currentObj;
    }


}
