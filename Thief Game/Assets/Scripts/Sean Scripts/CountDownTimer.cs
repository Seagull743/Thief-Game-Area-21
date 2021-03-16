using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0;
    float startingTime = 20;

    [SerializeField]
    private Text CountDownText;
    private bool spotted = false;
    public Alarm alarm;
    public PlayerGettingArrested PA;

    void Start()
    {
        CountDownText.enabled = false;
        currentTime = startingTime;
    }

    void Update()
    {

        if (spotted == true)
        {
            CountDownText.enabled = true;
            currentTime -= 1 * Time.deltaTime;
            CountDownText.text = currentTime.ToString("0");
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
            CountDownText.enabled = false;
            PA.GetComponent<PlayerGettingArrested>().DoAnim();
        }
    }


    public void Spotted()
    {
        spotted = true;     
    }

}
