using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;
    public bool onGround = false;
    GameObject Player;
    int JumpNo;
    public void DoubleJump;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.tag.gameObject;

        JumpNo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && onGround == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Player.GetComponent<PlayerMovement>().onGround = true;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Player.GetComponent<PlayerMovement>().onGround = false;
        }
    }
}
