using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionManager : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            GameObject.Find("GameManager").GetComponent<GameManager>().currentTime += 10;
            GameObject.Find("Player").GetComponent<DamagePointPlayer>().getTime(10);
            GameObject.Find("Player").GetComponent<PlayerMovement>().potionSoundPlay();
            Destroy(this.gameObject);
        }
    }
}
