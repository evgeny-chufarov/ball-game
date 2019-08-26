using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Ball2.speed = 0.3f;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Ball2.speed = 1.5f;
    }
}
