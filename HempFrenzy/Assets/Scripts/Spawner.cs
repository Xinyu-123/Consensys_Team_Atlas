using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] spawns;
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Instantiate(spawns[0], new Vector3(10*i + 5, (float) 3, 0), Quaternion.identity);
            Instantiate(spawns[1], new Vector3(10*i + (float)8.5, 4, 0), Quaternion.identity);
            Instantiate(spawns[1], new Vector3(10 * i + (float) 8.9, 4, 0), Quaternion.identity);
            Instantiate(spawns[1], new Vector3(10 * i +(float) 9.3, 4, 0), Quaternion.identity);

        }

        InvokeRepeating("SpawnThunder", 0f, 9.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnThunder()
    {
        for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 3; j++)
            Instantiate(spawns[2], new Vector3(10 * i + (float)5 + (float)(0.2*j), (float)3, 0), Quaternion.identity);
        }
    }
}
