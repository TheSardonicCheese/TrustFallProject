using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 20f;
    public Rigidbody2D rb;
    private Vector3 firingPoint;
    public float maxProjectileDist;
    public LayerMask layer;
    public float radius = 1f;
    public int damage = 1;
    public PlayerStats player;
    


    // Start is called before the first frame update
    void Start()
    {
        firingPoint = transform.position;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }

    void Update()
    {

        MoveBullet();

        /*Collider[] hits = Physics.OverlapSphere(transform.position, radius, layer);

        if (hits.Length > 0)
        {
            Debug.Log("hit player");
            foreach (Collider col in hits)
            {
                Debug.Log(col.name);
            }
            
            foreach (Collider col in hits)
            {
                    if (col.GetComponent<PlayerStats>())
                    {
                        col.GetComponent<PlayerStats>().lives -= 1;
                        //destroy player
                        //respawn player
                    }
            }
        }*/

    }
    void MoveBullet()
    {
        if (Vector3.Distance(firingPoint, transform.position) > maxProjectileDist)
        {
            Destroy(this.gameObject);
        }
        else
        {
            transform.Translate(Vector3.up * projectileSpeed * Time.deltaTime);
        }
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
            Debug.Log("Game Over"); 
       
    }
}
