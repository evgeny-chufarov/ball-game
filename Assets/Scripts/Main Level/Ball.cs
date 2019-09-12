using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform portalPoint;

    private Rigidbody2D rb;
    private SpriteRenderer ren;

    // Variables for speed control
    public float baseSpeed = 1.5f;
    public static float speed;
    
    // Variables for jumping
    public bool isGrounded;
    public LayerMask groundLayers;

    // Color
    public static bool isWood = false;
    public static bool isMetal = true;

    // Fire and Water
    public static bool inFire = false;
    public static bool mad = false;
    public static bool inWater = false;
    public static bool onTrampoline = false;

    // Health and key counter
    public static int health = 3;
    public bool hasKey = false;


    void Start()
    {
            rb = GetComponent<Rigidbody2D>();
            ren = GetComponent<SpriteRenderer>();
            speed = baseSpeed;
    }

    void Update()
    {
            // Get player's key
            float moveHorizontal = Input.GetAxis("Horizontal");

            // Define base movement and jump
            Vector2 movement = new Vector2(moveHorizontal, 0);
            Vector2 jump = new Vector2(0, 2);
            Vector2 high_jump = new Vector2(0, 4);

            // Acceleration
            rb.AddForce(movement * speed);

            // Restrict double jumping
            isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.05f, transform.position.y - 0.12f),
                new Vector2(transform.position.x + 0.05f, transform.position.y - 0.13f), groundLayers);

            // Jump
            if (Input.GetKeyDown("space") && isGrounded)
            {
                rb.AddForce(jump, ForceMode2D.Impulse);
            }

            if (Input.GetKeyDown("space") && isGrounded && onTrampoline)
            {
                rb.AddForce(high_jump, ForceMode2D.Impulse);
            }

        // Change material
            if (isWood == true)
            {
                ren.color = Color.white;
            }
            else if (isMetal == true)
            {
                ren.color = Color.black;
            }
            else if (mad == true)
            {
                ren.color = Color.gray;
                rb.mass = 1.1f;
            }
            else if (inWater == true)
            {
                ren.color = Color.white;
                rb.mass = 0.6f;
            }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire" && isWood)
        {
            rb.transform.position = spawnPoint.position;
            health--;
        }
        else if (other.gameObject.tag == "Portal" && isWood)
        {
            rb.transform.position = portalPoint.position;
        }
        else if (other.gameObject.tag == "Key")
        {
            hasKey = true;
            other.gameObject.SetActive(false);
        }

    }


    // Drawing an overlap area for an Object //
    ///////////////////////////////////////////
    //void OnDrawGizmos ()
    //{
    //   Gizmos.color = new Color(0, 1, 0, 0.5f);
    // Gizmos.DrawCube(new Vector2(transform.position.x, transform.position.y - 0.13f),
    //  new Vector2(0.1f, 0.01f));
    //}

}