using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    GameObject spawnerManager;
    public bool isActive;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && !isActive)
        {
            GameObject.Find("SpawnerManager").GetComponent<ReSpawnManager>().lastSpawnerUpper();
            isActive = true;
        }
    }
}
