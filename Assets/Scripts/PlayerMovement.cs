using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb;
    public Transform groundCheck;
    public float speed = 1000;
    public float jump = 1000;

    public LayerMask whatIsGround;
    public float groundRadius;
    public bool grounded;

    public KeyCode moveLeftKey;
    public KeyCode moveRightKey;
    public KeyCode jumpKey;

    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        if (Input.GetKey(jumpKey) && grounded)
        {
            rb.AddForce(Vector2.up * jump,ForceMode2D.Impulse);
        }


        if (Input.GetKey(moveRightKey))
        {
            rb.velocity = new Vector2(1 * speed, rb.velocity.y);

            transform.localScale = new Vector2(1, transform.localScale.y);
        }
        else if (Input.GetKey(moveLeftKey))
        {
            rb.velocity = new Vector2(-1 * speed, rb.velocity.y);

            transform.localScale = new Vector2(-1, transform.localScale.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
}
