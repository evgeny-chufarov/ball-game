using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramp : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Ball.onTrampoline = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Ball.onTrampoline = false;
    }

}
