using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("GameSelector");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void creditsGame()
    {
        Debug.Log("Lütfen daha sonra tekrar deneyiniz.!");
    }

}
