using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oil_triger : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other)
    {
       Ball2.speed = 4;
    }

    void OnTriggerExit2D(Collider2D other)
    {
       Ball2.speed = 1.5f;
    }

}
