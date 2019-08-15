﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = transform.position;
        if (viewPos.y > Camera.main.orthographicSize || viewPos.y < Camera.main.orthographicSize)
        {
            viewPos.y = Camera.main.orthographicSize;
        }
    }
}