using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Physics2D.gravity = new Vector2(0, -0.5f);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Physics2D.gravity = new Vector2(0, -9.8f);
    }

}
