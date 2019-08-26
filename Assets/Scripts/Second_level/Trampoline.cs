using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Ball2.on_trampoline = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Ball2.on_trampoline = false;
    }
}
