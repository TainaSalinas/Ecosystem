using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabLife : MonoBehaviour
{

    public float score;
    float randomX = 0.05f;
    float randomY = 0.05f;
    public string type = "crab";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position += new Vector3(Random.Range(-randomX, 0.02f),
        Random.Range(-randomY, randomY), 0);

        score++;

        if (score == 950)
        {
            StartCoroutine(Death());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "starfish")
        {
            Debug.Log("AH");
            StartCoroutine(Hurt());
        }
    }


    IEnumerator Death()
    {
        GetComponent<Renderer>().material.color = Color.grey;
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    IEnumerator Hurt()
    {
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = Color.white;
    }
}
