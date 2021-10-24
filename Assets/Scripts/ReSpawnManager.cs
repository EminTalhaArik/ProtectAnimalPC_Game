using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawnManager : MonoBehaviour
{

    public List<GameObject> spawner;
    public int lastSpawner;

    public float cuttingY;
    public float minPlayerY;

    GameObject player;

    void Start()
    {
        lastSpawner = 0;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        if(player.transform.position.y < minPlayerY)
        {
            player.transform.position = new Vector3(spawner[lastSpawner - 1].gameObject.transform.position.x, spawner[lastSpawner -1].gameObject.transform.position.y + cuttingY, 0);
        }
    }

    public void lastSpawnerUpper()
    {
        lastSpawner++;
    }
}
