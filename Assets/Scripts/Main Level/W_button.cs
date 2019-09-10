using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_button : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other)
    {
       Ball.isWood = true;
    }

}
