using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{

    public static GM instance;
    public GameObject player;

    public Transform Playercam;
    
    [SerializeField]
    private GameObject interactcross;
    [SerializeField]
    private GameObject normalcross;
    [SerializeField] private InteractiveObject currentObj;


    [SerializeField] private GameObject doorLockedText;
    [SerializeField] PlayerTargets playerTargets;



// for score
    [SerializeField] public Text scoreText;
    [SerializeField] public static int theScore;
  
    [SerializeField] private GameObject kryptoArtTick;

    [SerializeField] private GameObject SymbolArtTick;

    [SerializeField] private GameObject saberTick;

     [SerializeField] private GameObject exitGate;

     [SerializeField] private ParticleSystem GateEffect;
  
    void Awake()
    {

        theScore = 0;

        exitGate.SetActive(false);
        kryptoArtTick.SetActive(false);
        SymbolArtTick.SetActive(false);
        saberTick.SetActive(false);
        doorLockedText.SetActive(false);
        
        
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

    void Update()
    {
        scoreText.text = "Collected: " + theScore;


        
    
    
        if(theScore >= 1)
        {
            SpawnExitGate();
            GateEffect.Play();
        }
        else if(Alarm.Spotted == true)
        {
            SpawnExitGate();
            GateEffect.Play();
        }
        else
        {
            exitGate.SetActive(false);
            GateEffect.Stop();
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

     public void LockedDoor()
    {
         StartCoroutine(LockedText());
    }
    
    IEnumerator LockedText()
    {
        doorLockedText.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        doorLockedText.SetActive(false);
    }

    public PlayerTargets GetPlayerTargets()
    {
        if(playerTargets == null)
        {
            throw new System.Exception("Hey dingus set the playertargets on the GM");
        }
        return playerTargets;
    }


    //Artifacts Tick complete

    public void kryptoTick()
    {
        kryptoArtTick.SetActive(true);
    }

     public void SymbolTick()
    {
        SymbolArtTick.SetActive(true);
    }

     public void SaberTick()
    {
        saberTick.SetActive(true);
    }

    public void SpawnExitGate()
    {
        exitGate.SetActive(true);
    }

    

}
