using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    private float y;
    void Start()
    {
        
        offset = transform.position - player.transform.position;
        y = player.transform.position.y;
    }

   
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x + offset.x, y + offset.y, offset.z);
    }
}
