using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogHouseManager : MonoBehaviour
{

    public bool waterIsFull;
    public int waterCount;

    public GameObject defaultWaterBottle;
    public GameObject newWaterBottle;

    public GameObject heart;

    public Button waterButton;

    public AudioSource dogHouseSound;

    void Start()
    {
        waterCount = 0;
        waterIsFull = false;
        waterButton = GameObject.Find("WaterButton").GetComponent<Button>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (waterCount >= 1 && !waterIsFull)
            {
                bottleIsTrue();
            }
        }
        
    }

    public void bottleIsTrue()
    {
        if(waterCount >= 1 && !waterIsFull) 
        {
            defaultWaterBottle.gameObject.GetComponent<SpriteRenderer>().sprite = newWaterBottle.gameObject.GetComponent<SpriteRenderer>().sprite;
            waterIsFull = true;
            GameObject.Find("GameManager").GetComponent<GameManager>().waterScoreUp();
            dogHouseSound.Play();
            heart.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            waterCount = 1;
            GameObject.Find("DogManager").GetComponent<DogManager>().dogHouse = this.gameObject;
            if (!waterButton.gameObject.activeSelf)
            {
                waterButton.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        waterCount = 0;
        waterButton.gameObject.SetActive(false);
        GameObject.Find("DogManager").GetComponent<DogManager>().dogHouse = null;
    }
}
