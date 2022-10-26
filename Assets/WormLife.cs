using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormLife : MonoBehaviour
{
    public float score;
    float randomX = 8f;
    float randomY = 4f;
    public float counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;

        if (counter == 500)
        {
            this.transform.position += new Vector3(Random.Range(-randomX, randomX),
            Random.Range(-randomY,randomY), 0);
            counter = 0;
        }

        score++;

        if (score == 1500)
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
