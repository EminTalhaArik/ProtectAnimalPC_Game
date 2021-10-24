using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public GameObject pauseMenu;
    public string sceneName = "";
    public GameObject gameOverPanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenPauseMenu();
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void ExitRoom()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void OpenPauseMenu()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
        
    }

    public void GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    } 
    
    public void RestartGameOver()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }

}
