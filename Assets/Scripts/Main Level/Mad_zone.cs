using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mad_zone : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Ball.mad = true;
    }

}
