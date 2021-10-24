using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float currentTime;
    public Text timeText;

    public int waterScore;
    public Text waterScoreText;

    

    void Start()
    {
        waterScoreText.text = "" + waterScore;
        Time.timeScale = 1;
        
    }
     
    void Update()
    {
        // Sayaç Geri Sayım

        timeText.text = "" + (int) currentTime;
        currentTime -= Time.deltaTime;

        

        if(currentTime <= 0)
        {
            //Game Over
            Time.timeScale = 0;
            GameObject.Find("Canvas").GetComponent<MenuManager>().gameOverPanel.gameObject.SetActive(true);
        }
        
        if(waterScore <= 0)
        {
            waterScore = 0;
        }
    }

    public void waterScoreUp()
    {
        waterScore++;
        waterScoreText.text = "" + waterScore; 
    }

}
