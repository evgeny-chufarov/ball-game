using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball3 : MonoBehaviour
{
    private Rigidbody2D rb;
        
    // Variables for speed control
    public float baseSpeed = 1.5f;
    public static float speed;
    
    // Variables for jumping
    public bool isGrounded;
    public LayerMask groundLayers;
    
    void Start()
    {
            rb = GetComponent<Rigidbody2D>();
            speed = baseSpeed;
    }

    void Update()
    {
            // Get player's key
            float moveHorizontal = Input.GetAxis("Horizontal");

            // Define base movement and jump
            Vector2 movement = new Vector2(moveHorizontal, 0);
            Vector2 jump = new Vector2(0, 1);

            // Acceleration
            rb.AddForce(movement * speed);

            // Restrict double jumping
            isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.05f, transform.position.y - 0.31f),
                new Vector2(transform.position.x + 0.05f, transform.position.y - 0.32f), groundLayers);

            // Jump
            if (Input.GetKeyDown("space") && isGrounded)
            {
                rb.AddForce(jump, ForceMode2D.Impulse);
            }
            
    }

    // Drawing an overlap area for an Object //
    ///////////////////////////////////////////
    //void OnDrawGizmos ()
    //{
    //    Gizmos.color = new Color(0, 1, 0, 0.5f);
    //    Gizmos.DrawCube(new Vector2(transform.position.x, transform.position.y - 0.325f),
    //       new Vector2(0.1f, 0.01f));
    //}

}