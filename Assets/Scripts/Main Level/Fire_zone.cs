﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_zone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(gameObject.name, gameObject);
        Ball.inFire = true;
    }

}
