using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Ball.baseSpeed = 5.0f;
        Debug.Log(Ball.baseSpeed);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Ball.baseSpeed = 1.5f;
        Debug.Log(Ball.baseSpeed);
    }
}
