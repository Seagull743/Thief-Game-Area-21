using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScoreText : MonoBehaviour
{

    public Text scoreText;

    void Start()
    {
        scoreText.text = "Artifacts Collected: " + GM.theScore;
    }

    
}
