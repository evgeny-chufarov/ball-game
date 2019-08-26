using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    private Rigidbody2D rb;    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //// For 0.0 start coordinates
        
        //transform.position = new Vector2(Mathf.PingPong(Time.time * 5, 7.87f), transform.position.y);
        
        //// For the non-zero starting loopping point
        transform.position = new Vector2(transform.position.x, Mathf.Lerp(0.57f, -3.18f, Mathf.PingPong(Time.time * 0.35f, 1)));
    }
}
