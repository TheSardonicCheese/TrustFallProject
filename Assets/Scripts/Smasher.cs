using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Smasher : MonoBehaviour
{
    public float timer;
    public float delay;
    public Vector3 target;
    public Vector3 returnPos;
    public Vector3 startPos;
    public int speed;
    private bool smash = false;
    public GameObject returnPoint;
    public GameObject targetPoint;
    public PlayerStats player;


    void Start()
    {
        returnPos = returnPoint.transform.position;
        target = targetPoint.transform.position;
        StartCoroutine(StartDelay());
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (smash == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position == target)
            {
                startPos = target;
                target = returnPos;
                returnPos = startPos;
                smash = false;
                StartCoroutine(Countdown());
                
            }
        }
        
        //when time is over move smasher
        //destroy anything that colides should be the same as arrow and spikes
    }
    public IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(delay);
        StartCoroutine(Countdown());
    }

    public IEnumerator Countdown()
    {
        yield return new WaitForSeconds(timer);
        smash = true;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (player.lives > 0)
        {
            Debug.Log(col.name);
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
