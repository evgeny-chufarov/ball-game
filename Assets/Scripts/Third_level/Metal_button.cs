using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal_button : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other)
    {
       Ball3.metal = true;
    }

}
