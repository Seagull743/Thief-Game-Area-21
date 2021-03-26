using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGettingArrested : MonoBehaviour
{
    public Animator anim;
    public Cameralook Cl;
    public PlayerMovement PM;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    public void DoAnim()
    {
        anim.SetBool("isArrested", true);
        Cl.GetComponent<Cameralook>().enabled = false;
        PM.GetComponent<PlayerMovement>().enabled = false;
      //  FindObjectOfType<AudioManager>().Play("a");
        Invoke("LoadSceneTime", 3f);
    }


    public void LoadSceneTime()
    {
        SceneManager.LoadScene("GameOver");
    }
    
}
