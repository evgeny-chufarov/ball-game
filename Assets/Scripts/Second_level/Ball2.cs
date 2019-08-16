using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    private Rigidbody2D rb;
        
    // Variables for speed control
    public float baseSpeed = 1.5f;
    public static float speed;
    public bool am_i_faster = false;
    public bool am_i_slower = false;

    // Variables for jumping
    public bool isGrounded;
    public LayerMask groundLayers;
    public static bool on_trampoline = false;

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
            isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.35f, transform.position.y - 0.35f),
                new Vector2(transform.position.x + 0.35f, transform.position.y - 0.36f), groundLayers);

            // Jump
            if (Input.GetKeyDown("space") && on_trampoline && isGrounded)
            {
                jump = new Vector2(0, 2);
                rb.AddForce(jump, ForceMode2D.Impulse);
            }
            else if (Input.GetKeyDown("space") && !on_trampoline && isGrounded)
            {
                rb.AddForce(jump, ForceMode2D.Impulse);
            }

            // Visualising speed altering
            if (speed == 4)
            {
                am_i_faster = true;
            }
            else if (speed == 0.3f)
            {
                am_i_slower = true;
            }
            else
            {
                am_i_faster = false;
                am_i_slower = false;
            }
    }

    // Drawing an overlap area for an Object //
    ///////////////////////////////////////////
    //void OnDrawGizmos ()
    //{
    //    Gizmos.color = new Color(0, 1, 0, 0.5f);
    //    Gizmos.DrawCube(new Vector2(transform.position.x, transform.position.y - 0.355f),
    //       new Vector2(1, 0.01f));
    //}

}