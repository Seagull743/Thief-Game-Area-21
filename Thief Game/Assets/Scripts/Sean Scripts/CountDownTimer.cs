using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0;
    float startingTime = 25;

    [SerializeField]
    private Text CountDownText;
    private bool spotted = false;
    public Alarm alarm;
    public PlayerGettingArrested PA;

    private AudioManager am;

    public bool isplayed = false;

    void Start()
    {
        CountDownText.enabled = false;
        currentTime = startingTime;
        am = FindObjectOfType<AudioManager>();
    }

    void Update()
    {

        if (spotted == true)
        {
            CountDownText.enabled = true;
            currentTime -= 1 * Time.deltaTime;
            CountDownText.text = currentTime.ToString("0");
        }

        if (currentTime <= 0 && !isplayed)
        {
            currentTime = 0;
            CountDownText.enabled = false;
            am.Play("a");
            Invoke("ArrestAnim", 2f);
            isplayed = true;   
        }
        else if (isplayed)
        {
            currentTime = 0;
        }
       
        
    }

    public void ArrestAnim()
    {
        PA.GetComponent<PlayerGettingArrested>().DoAnim();
    }


    public void Spotted()
    {
        spotted = true;     
    }

}
