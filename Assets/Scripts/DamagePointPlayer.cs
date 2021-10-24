using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamagePointPlayer : MonoBehaviour
{
    public GameObject text;
    public List<GameObject> points;
    public int randomCount;
    public GameObject spawnEffect;

    public void getDamage(float damage)
    {
        randomCount = Random.Range(0, points.Count);
        spawnEffect = Instantiate(text,points[randomCount].transform.position,Quaternion.identity);
        spawnEffect.GetComponent<TextMesh>().text = "" + damage;
        spawnEffect.GetComponent<TextMesh>().color = Color.red ;
        spawnEffect.transform.SetParent(GameObject.Find("Player").transform);
        StartCoroutine(deleteText(spawnEffect));
    }

    public void getTime(int time)
    {
        randomCount = Random.Range(0, points.Count);
        spawnEffect = Instantiate(text, points[randomCount].transform.position, Quaternion.identity);
        spawnEffect.GetComponent<TextMesh>().text = "" + time;
        spawnEffect.GetComponent<TextMesh>().color = Color.white;
        spawnEffect.transform.SetParent(GameObject.Find("Player").transform);
        StartCoroutine(deleteText(spawnEffect));
    }
    
    IEnumerator deleteText(GameObject destroySpawnEffect)
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(destroySpawnEffect);
    }

}
