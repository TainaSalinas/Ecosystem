using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarfishLife : MonoBehaviour
{

    public float score;
    float randomX = 0.1f;
    float randomY = 0.5f;
    public float counter;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;

        if (counter == 120)
        {
            this.transform.position += new Vector3(Random.Range(-randomX, randomX),
            randomY, 0);
            counter = 0;
        }

        score++;

        if (score == 2500)
        {
            StartCoroutine(Death());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "crab")
        {
            Debug.Log("Freeze");
            counter = -2500;
        }
    }

    IEnumerator Death()
    {
        GetComponent<Renderer>().material.color = Color.grey;
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
