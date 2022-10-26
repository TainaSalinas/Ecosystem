using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabSpawn : MonoBehaviour
{

    public GameObject CrabPrefab;
    float counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randX = Random.Range(8f, 8.75f);
        float randY = Random.Range(0f, 4f);

        if(counter == 400)
        {
            GameObject.Instantiate(CrabPrefab, new Vector3(randX, randY, 0), Quaternion.identity);
            counter = 0;
        }

        counter++;
    }
}
