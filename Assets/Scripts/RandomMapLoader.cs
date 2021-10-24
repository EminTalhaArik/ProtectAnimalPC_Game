using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMapLoader : MonoBehaviour
{

    public List<GameObject> scenes;
    public int loadCount;
    int newID;
    int loadScene;
    float lastPosX;
    GameObject spawnerManager;

    void Start()
    {
        spawnerManager = GameObject.Find("SpawnerManager");

        newID = 0;
        lastPosX = 31;
        for(int i = 0; i <= loadCount; i++)
        {
            newID = i;
            loadScene = Random.Range(0, scenes.Count);
            GameObject map = Instantiate(scenes[loadScene]);

            if(newID == 0)
            {
                map.transform.position = new Vector3(lastPosX, 0.2f, 0);


            }
            else
            {
                map.transform.position = new Vector3(lastPosX + 72 , 0.2f, 0);

            }
            spawnerManager.GetComponent<ReSpawnManager>().spawner.Add(map.transform.Find("Spawner").gameObject);
            lastPosX = map.transform.position.x;
        }
    }

    
    void Update()
    {
        
    }
}
