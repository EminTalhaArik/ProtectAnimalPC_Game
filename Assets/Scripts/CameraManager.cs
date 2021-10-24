using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private GameObject player;
    
    [SerializeField]
    private float smoothX;
    [SerializeField]
    private float smoothY;

    [SerializeField]
    private float minX;
    [SerializeField]
    private float minY;
    [SerializeField]
    private float maxX;
    [SerializeField]
    private float maxY;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate()
    {
        float posX = Mathf.MoveTowards(transform.position.x, player.transform.position.x, smoothX);
        float posY = Mathf.MoveTowards(transform.position.y, player.transform.position.y, smoothY);

        transform.position = new Vector3(Mathf.Clamp(posX, minX, maxX), Mathf.Clamp(posY, minY, maxY), transform.position.z);
    }
}
