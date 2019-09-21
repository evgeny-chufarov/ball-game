using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud_zone : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Ball.isWood)
        {
           Ball.inMud = true;
        }
    }

}
