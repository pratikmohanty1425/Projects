using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwner : MonoBehaviour
{
    public GameObject[] virus;
    public GameObject mask;
    float max = 1.97f;
    float min = -1.97f;
    int i;
    void Start()
    {
        StartCoroutine(bombdrop());
        StartCoroutine(maskdrop());
    }
    IEnumerator bombdrop()
    {
        yield return new WaitForSeconds(Random.Range(0, 1.5f));
        int i = Random.Range(0, 2);
        float j = Random.Range(0.5f, 1);
        Instantiate(virus[i], new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        StartCoroutine(bombdrop());
    }

    IEnumerator maskdrop()
    {
        yield return new WaitForSeconds(Random.Range(0, 2f));
        i = Random.Range(0, 50);
        if (i >= 1 && i <= 10)
        {
            Instantiate(mask, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        }
        StartCoroutine(maskdrop());
    }
}
