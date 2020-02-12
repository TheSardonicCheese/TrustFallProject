using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //destroy anything that colides should be the same as arrow and spikes
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);
        col.transform.position = GameObject.FindGameObjectWithTag("RespawnPoint").transform.position;
    }
}
