using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabLife : MonoBehaviour
{

    public float score;
    float randomX = 0.10f;
    float randomY = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position += new Vector3(Random.Range(-randomX, 0.01f),
        Random.Range(-randomY, randomY), 0);

        score++;

        if (score == 1000)
        {
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        GetComponent<Renderer>().material.color = Color.grey;
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
