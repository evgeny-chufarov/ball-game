using UnityEngine;
using System.Collections;

public class Ball_control : MonoBehaviour
{

    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D player;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public float forceX = 0, forceY = 0;
    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        player = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {


        if (Input.anyKey)
        {


            if (Input.GetKey("up"))
            { forceX = 0; forceY = speed; }
            if (Input.GetKey("down"))
            { forceX = 0; forceY = -speed; }
            if (Input.GetKey("left"))
            { forceX = -speed; forceY = 0; }
            if (Input.GetKey("right"))
            { forceX = speed; forceY = 0; }

            float playerX = player.position.x;
            float playerY = player.position.y;

            player.MovePosition(new Vector2(playerX + forceX, playerY + forceY));

        }



    }
}
