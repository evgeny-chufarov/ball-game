using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCol : MonoBehaviour
{
    Collider2D door;

    // Start is called before the first frame update
    void Start()
    {
        door = GetComponent<Collider2D>();
        door.isTrigger = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && Ball.hasKey)
        {
            door.isTrigger = true;
        }
    }
}
