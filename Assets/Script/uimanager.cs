using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uimanager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject settingsPanel;
    public GameObject scoreboard;

    public void OpenSettings()
    {
        scoreboard.SetActive(false);
        startPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        scoreboard.SetActive(false);
        settingsPanel.SetActive(false);
        startPanel.SetActive(true);
    }

    public void StartGame()
    {
        scoreboard.SetActive(true);
        gamestate.isPlaying = true;
        startPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();

        Debug.Log("Game Closed");
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        gamestate.isPlaying = true;
        scoremanager.instance.score = 0 ;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    
}
