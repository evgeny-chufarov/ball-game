using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_button : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other)
    {
       Ball.isMetal = true;
    }

}
