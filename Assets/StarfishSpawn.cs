using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarfishSpawn : MonoBehaviour
{

    public GameObject StarPrefab;
    float counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randX = Random.Range(-4.7f, 6.7f);
        float randY = Random.Range(-4.7f, -4.74f);

        if (counter == 600)
        {
            GameObject.Instantiate(StarPrefab, new Vector3(randX, randY, 0), Quaternion.identity);
            counter = 0;
        }

        counter++;
    }
}
