using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallPlatformScript : MonoBehaviour
{

    public Transform firstPos;
    public Transform secondPos;
    public float speed;

    Transform nextPos;

    void Start()
    {
        nextPos = firstPos;
    }

    
    void Update()
    {
        if (transform.position == firstPos.position)
            nextPos = secondPos;

        if (transform.position == secondPos.position)
            nextPos = firstPos;

        transform.position = Vector3.MoveTowards(transform.position, nextPos.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            collision.collider.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            collision.collider.transform.SetParent(null);
    }
}
