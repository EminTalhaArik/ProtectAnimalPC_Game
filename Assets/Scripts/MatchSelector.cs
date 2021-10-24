using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchSelector : MonoBehaviour
{

    
    public string joinRoom = "";
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(joinRoom);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void buttonDown()
    {
        SceneManager.LoadScene(joinRoom);
        
    }

    public void exitRoom()
    {
        SceneManager.LoadScene(0);
    }
    
}
