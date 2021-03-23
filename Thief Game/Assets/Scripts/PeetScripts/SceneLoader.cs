using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameAnalyticsSDK;
public class SceneLoader : MonoBehaviour
{
    public void Start()
    {
        GameAnalytics.Initialize();
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "BootedGame");
    }
    private void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Play()
    {
        SceneManager.LoadScene("GamePlay");
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start,"StartedGame");
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene("StartMenu");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
