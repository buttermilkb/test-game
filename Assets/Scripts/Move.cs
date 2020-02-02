using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed;
    public float jumpSpeed;

    private Vector2 position;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        position = transform.position;
    }

    void Update()
    {
        updatePosition();
    }

    void flip()
    {
        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void updatePosition()
    {
        //Vector2 location = transform.position;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (transform.localScale.x > 0)
            {
                flip();
            }
            //location.x -= moveSpeed * Time.deltaTime;
            rb.velocity = Vector2.left * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (transform.localScale.x < 0)
            {
                flip();
            }
            //location.x += moveSpeed * Time.deltaTime;
            rb.velocity = Vector2.right * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //location.y += jumpSpeed * Time.deltaTime;
            rb.velocity = Vector2.up * jumpSpeed;
        }
        //transform.position = location;
    }
}
