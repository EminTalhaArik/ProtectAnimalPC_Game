using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDeleterPlatform : MonoBehaviour
{

    GameObject gameManager;
    public int deleterScore;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GetComponent<GameManager>().currentTime -= deleterScore;
        GameObject.Find("Player").GetComponent<DamagePointPlayer>().getDamage(deleterScore);
        GameObject.Find("Player").GetComponent<PlayerMovement>().scoreDeleterPlatformSoundPlay();
    }

}
