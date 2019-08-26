using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood_button : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other)
    {
       Ball3.wood = true;
    }

}
