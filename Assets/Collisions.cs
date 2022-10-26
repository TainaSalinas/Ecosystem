using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public string type = "star";
    private string[] typeOptions = new[] { "star", "crab" };

    public Sprite star;
    public Sprite crab;

    private void Start()
    {
        type = typeOptions[Random.Range(0, 2)];
    }

    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collisions them = collision.gameObject.GetComponent<Collisions>();
        type = ResolveSC(type, them.type);
        SetAppropriateSprite();
    }

    private string ResolveSC(string me, string them)
    {
        if(me == "star" && them == "crab")
        {
            return "crab";
        }

        return me;
    }

    private void SetAppropriateSprite()
    {
        if(type == "star")
        {
            this.GetComponent<SpriteRenderer>().sprite = star;
        }
        if (type == "crab")
        {
            this.GetComponent<SpriteRenderer>().sprite = crab;
        }
    }
    
}

// return me.transform.position += new Vector3(Random.Range(-0.02, 0.10f),
// Random.Range(-0.05f, 0.05f), 0);
