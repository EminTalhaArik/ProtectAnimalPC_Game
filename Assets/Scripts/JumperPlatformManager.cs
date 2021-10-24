using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperPlatformManager : MonoBehaviour
{

    GameObject player;

    public float jumpPowerY;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player = collision.gameObject;
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpPowerY));
            GameObject.Find("Player").GetComponent<PlayerMovement>().jumpSoundPlay();
        }
    }
}