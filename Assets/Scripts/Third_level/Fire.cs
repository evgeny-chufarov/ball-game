using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other)
    {
       Ball3.in_fire = true;
    }

}
