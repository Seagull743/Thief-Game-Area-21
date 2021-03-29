using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGettingArrested : MonoBehaviour
{
    public Cameralook Cl;
    public PlayerMovement PM;



    public void DoAnim()
    {
        Cl.GetComponent<Cameralook>().enabled = false;
        PM.GetComponent<PlayerMovement>().enabled = false;
        Invoke("LoadSceneTime", 3f);
    }


    public void LoadSceneTime()
    {
        SceneManager.LoadScene("GameOver");
    }
    
}
