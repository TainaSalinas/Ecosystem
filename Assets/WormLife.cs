using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormLife : MonoBehaviour
{
    public float score;
    float randomX = 7f;
    float randomY = 3.5f;
    public float counter;
    public string type = "worm";

    public GameObject starfish;
    public GameObject crab;

    public AudioSource Worm;


    // Start is called before the first frame update
    void Start()
    {
            this.GetComponent<AudioSource>().Play();

    }

    // Update is called once per frame
    void Update()
    {
        counter++;

        if (counter == 500)
        {
            this.transform.position += new Vector3(Random.Range(-randomX, randomX),
            Random.Range(-randomY,randomY), 0);
            this.GetComponent<AudioSource>().Play();
            counter = 0;
        }

        score++;

        if (score == 1500)
        {
            StartCoroutine(Death());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "crab")
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "starfish")
        {
            Debug.Log("hit");
            this.transform.position += new Vector3(Random.Range(-randomX, randomX),
            Random.Range(-randomY, randomY), 0);
            this.GetComponent<AudioSource>().Play();
        }
    }

    IEnumerator Death()
    {
        GetComponent<Renderer>().material.color = Color.grey;
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
