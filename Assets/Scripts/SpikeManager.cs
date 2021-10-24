using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeManager : MonoBehaviour
{

    public int destroyCount;

    

    void Start()
    {
        
    }

    
    void Update()
    {
        if(destroyCount <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().currentTime -= 5;
            GameObject.Find("Player").GetComponent<DamagePointPlayer>().getDamage(5);
            GameObject.Find("Player").GetComponent<PlayerMovement>().spikeSoundPlay();
            destroyCount--;
        }
    }
}
