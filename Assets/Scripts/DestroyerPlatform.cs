using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerPlatform : MonoBehaviour
{

    public GameObject platform;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        StartCoroutine(DestroyPlatform());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        StartCoroutine(CreatePlatform());
    }

    IEnumerator DestroyPlatform()
    {
        yield return new WaitForSeconds(0.5f);
        platform.SetActive(false);
        GameObject.Find("Player").GetComponent<PlayerMovement>().destroyerPlatformSoundPlay();
    }

    IEnumerator CreatePlatform()
    {
        yield return new WaitForSeconds(1.5f);
        platform.SetActive(true);
    }
}
