using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public GameObject newBack;
    public GameObject firstBack;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            spawnBack();
        }
    }

    void spawnBack()
    {
        firstBack = (GameObject)Instantiate(newBack, firstBack.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
