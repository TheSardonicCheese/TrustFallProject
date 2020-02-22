using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    public PlayerStats player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //destroy anything that colides should be the same as arrow and spikes
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (player.lives > 0)
        {
            col.transform.position = GameObject.FindGameObjectWithTag("RespawnPoint").transform.position;
            player.lives -= 1;
        }
        else
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("Difficulty Selector");
        }
    }
}
