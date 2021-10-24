using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerPlatform : MonoBehaviour
{

    GameObject player;

    public float newSpeed;
    public float newJumpPower;
    
    public float defaultSpeed;
    public float defaultJumpPower;

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
            
            player.GetComponent<PlayerMovement>().speed = newSpeed;
            player.GetComponent<PlayerMovement>().JumpPower = newJumpPower;
            StartCoroutine(DefaultPowers());
        }    
    }

    IEnumerator DefaultPowers()
    {
        yield return new WaitForSeconds(5);
        player.GetComponent<PlayerMovement>().speed = defaultSpeed;
        player.GetComponent<PlayerMovement>().JumpPower = defaultJumpPower;
    }
   
}
