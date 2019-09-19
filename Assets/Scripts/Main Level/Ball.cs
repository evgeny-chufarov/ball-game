using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Ball : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform portalPoint;
    [SerializeField] Transform downPoint;


    public Joystick joystick;

    // Variables for accessing the main game object
    private Rigidbody2D rig_body;
    private SpriteRenderer sprite_rend;
    private BuoyancyEffector2D water_density;

    // Variables for speed control
    public static float baseSpeed = 2.0f;
    public float speed;
    
    // Variables for jumping
    public bool isGrounded;
    public LayerMask groundLayers;

    // Material of the ball
    public static bool isWood = true;
    public static bool isMetal = false;

    // Fire and Water
    public static bool inFire = false;
    public static bool inMud = false;
    public static bool inWater = false;
    public static bool onTrampoline = false;

    // Health and key counter
    public static int health = 5;
    public static bool hasKey = false;


    void Start()
    {
        rig_body = GetComponent<Rigidbody2D>();
        sprite_rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Get player's key
        float moveHorizontal = joystick.Horizontal;

        // Define base movement and jump
        Vector2 movement = new Vector2(moveHorizontal, 0);
        Vector2 jump = new Vector2(0, 2);
        Vector2 high_jump = new Vector2(0, 4);

        // Acceleration
        speed = baseSpeed;
        rig_body.AddForce(movement * speed);

        #region Jumps
            // Jumps
            if (CrossPlatformInputManager.GetButtonDown("Jump") && isGrounded)
            {
                rig_body.AddForce(jump, ForceMode2D.Impulse);
                FindObjectOfType<AudioManager>().Play("Jump");
            }

            if (CrossPlatformInputManager.GetButtonDown("Jump") && isGrounded && onTrampoline)
            {
                rig_body.AddForce(high_jump, ForceMode2D.Impulse);
                FindObjectOfType<AudioManager>().Play("Trampoline");
            }

            // Restrict double jumping
            isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.05f, transform.position.y - 0.12f),
            new Vector2(transform.position.x + 0.05f, transform.position.y - 0.13f), groundLayers);

            #endregion

        // Material changes
        if (isWood)
        {
            sprite_rend.color = Color.white;
        }
        else if (isMetal)
        {
            sprite_rend.color = Color.black;
        }

        // Mass changes depending on the mud and water
        if (inMud && isWood)
        {
            sprite_rend.color = Color.gray;
            rig_body.mass = 0.9f;
        }
        else if (inWater && isWood)
        {
            sprite_rend.color = Color.white;
            rig_body.mass = 0.6f;
        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        // Fire
        if (other.gameObject.tag == "Fire" && isWood)
        {
            rig_body.transform.position = spawnPoint.position;
            health--;
        }

        // Portal
        if (other.gameObject.tag == "Portal" && isWood)
        {
            rig_body.transform.position = portalPoint.position;
            FindObjectOfType<AudioManager>().Play("Teleport");
        }

        // Don't let the ball down
        if (other.gameObject.tag == "NotDown")
        {
            rig_body.transform.position = downPoint.position;
        }

        // Getting the key
        if (other.gameObject.tag == "Key")
        {
            hasKey = true;
        }

        // High voltage zone
        if (other.gameObject.tag == "Electro" && isMetal)
        {
            rig_body.transform.position = spawnPoint.position;
            health--;
        }

        // Death spikes
        if (other.gameObject.tag == "Obstacle")
        {
            rig_body.transform.position = spawnPoint.position;
            health--;
        }

        // Water
        if (other.gameObject.tag == "Water" && isMetal)
        {
            water_density = other.GetComponent<BuoyancyEffector2D>();
            water_density.density = 10;

            FindObjectOfType<AudioManager>().Play("Water");
        }
    }
} // class


#region Drafts
///// Ball movements for PC version ///////

//float moveHorizontal = Input.GetAxis("Horizontal");



//////// Jumps for PC version /////////////

//if (Input.GetKeyDown("space") && isGrounded)
//{
//    rig_body.AddForce(jump, ForceMode2D.Impulse);
//}

//if (Input.GetKeyDown("space") && isGrounded && onTrampoline)
//{
//    rig_body.AddForce(high_jump, ForceMode2D.Impulse);
//}


// Drawing an overlap area for an Object //

//void OnDrawGizmos ()
//{
//   Gizmos.color = new Color(0, 1, 0, 0.5f);
// Gizmos.DrawCube(new Vector2(transform.position.x, transform.position.y - 0.13f),
//  new Vector2(0.1f, 0.01f));
//}

#endregion