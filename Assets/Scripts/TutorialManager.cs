using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialText; 

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        tutorialText.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        tutorialText.SetActive(false);
    }

}
