using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallDeath : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Ball.health == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
