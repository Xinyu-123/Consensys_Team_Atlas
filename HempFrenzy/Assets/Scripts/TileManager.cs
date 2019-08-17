using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    public GameObject firstTile;
    public GameObject newTile;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            spawnTile();
        }

        for (int i = 0; i < 500; i++)
        {
            spawnTileAndPickup();
        }
       
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void spawnTile()
    {
        firstTile = (GameObject)Instantiate(newTile, firstTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
    }

    void spawnTileAndPickup()
    {
        firstTile = (GameObject)Instantiate(newTile, firstTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);

        int hempPickup = Random.Range(0, 15); //range from 0 to 14

        if (hempPickup == 0)
        {
            firstTile.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
        }
        else if (hempPickup == 1 || hempPickup == 2)
        {
            firstTile.transform.GetChild(0).GetChild(2).gameObject.SetActive(true);
        }
    }
}
