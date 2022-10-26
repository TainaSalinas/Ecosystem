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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "crab")
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
    }

    IEnumerator Death()
    {
        GetComponent<Renderer>().material.color = Color.grey;
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
