using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameAnalyticsSDK;

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


    [SerializeField] private GameObject notworthytext;



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
        notworthytext.SetActive(false);
        Alarm.Spotted = false;
        theScore = 0;
        GateEffect.Stop();
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


        if (theScore > 0)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "ArtifactsColected" , theScore);
        }
        else if (theScore == 3)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "They Got all three Artifacts");
        }
    
    
        if(theScore >= 1)
        {
            SpawnExitGate();
            GateEffect.Play();
        }
        else if(Alarm.Spotted == true)
        {
            SpawnExitGate();       
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
        GateEffect.Play();
    }

    public void thortext()
    {
        notworthytext.SetActive(true);
        Invoke("thortextfalse", 2f);
    }
    
    public void thortextfalse()
    {
        notworthytext.SetActive(false);
    }

}
