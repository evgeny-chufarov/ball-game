using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_zone : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Ball.inMud = false;
        Ball.inWater = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Ball.inWater = false;
    }
}
