using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorsOpen : MonoBehaviour
{
    public Button joinButton;
    GameObject matchSelector;
    public GameObject textObject;

    void Start()
    {
        matchSelector = GameObject.Find("MatchSelector");
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            joinButton.gameObject.SetActive(true);
            textObject.gameObject.SetActive(true);
            matchSelector.GetComponent<MatchSelector>().joinRoom = this.gameObject.name;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            joinButton.gameObject.SetActive(false);
            textObject.gameObject.SetActive(false);
        }
    }
}
