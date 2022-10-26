using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormSpawn : MonoBehaviour
{

    public GameObject WormPrefab;
    float counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randX = Random.Range(-8.3f, 8.3f);
        float randY = Random.Range(-4f, 4f);

        if (counter == 2000)
        {
            GameObject.Instantiate(WormPrefab, new Vector3(randX, randY, 0), Quaternion.identity);
            counter = 0;
        }

        counter++;
    }
}
