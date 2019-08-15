using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Ball2 : MonoBehaviour
    {
        private Rigidbody2D rb;
           
        public float baseSpeed = 1.5f;
        public static float speed;
        public bool am_i_faster = false;
    
        // Use this for initialization
    void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            speed = baseSpeed;
        }

    // Update is called once per frame
    void Update()
        {
            // Get player's key
            float moveHorizontal = Input.GetAxis("Horizontal");

            // Define base movement and jump
            Vector2 movement = new Vector2(moveHorizontal, 0);
            Vector2 jump = new Vector2(0, 1);

            // Acceleration
            rb.AddForce(movement * speed);

            // Jump
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(jump, ForceMode2D.Impulse);
            }

            if (speed == 4)
            {
                am_i_faster = true;
            }
            else
            {
            am_i_faster = false;
            }

        }
}