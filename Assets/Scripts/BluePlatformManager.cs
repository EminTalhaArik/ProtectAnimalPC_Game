using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlatformManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovement>().speed = 3;
            collision.gameObject.GetComponent<PlayerMovement>().JumpPower = 200;

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovement>().speed = 5;
            collision.gameObject.GetComponent<PlayerMovement>().JumpPower = 250;
        }
    }
}
