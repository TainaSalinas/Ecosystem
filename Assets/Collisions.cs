using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public string type = "worm";
    public string type1 = "crab";

    // private string[] typeOptions = new[] { "star", "crab", "worm" };

    public Sprite star;
     public Sprite crab;
     public Sprite worm;

    private void Start()
    {
        //type = typeOptions[Random.Range(0, 3)];
       SetAppropriateSprite();
    }

    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collisions them = collision.gameObject.GetComponent<Collisions>();
        ResolveSC(type, them.type1);
    }

    private void ResolveSC(string me, string them)
    {
        if(me == "worm" && them == "crab")
        {
            Destroy(gameObject);
        }

       // if(me == "crab" && them == "starfish")
       // {
                //transform.position += new Vector3 (Random.Range(-0.04f, 0.04f),
                //Random.Range(-0.1f, 0.3f), 0);
       // }
    }

    private void SetAppropriateSprite()
    {
        if (type == "crab")
        {
            this.GetComponent<SpriteRenderer>().sprite = crab;
        }

        else if (type == "worm")
        {
            this.GetComponent<SpriteRenderer>().sprite = worm;
        }
    }

}

// return me.transform.position += new Vector3(Random.Range(-0.02, 0.10f),
// Random.Range(-0.05f, 0.05f), 0);
