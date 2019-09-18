using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{

    private int health = 3;
    public Text healthText;

    void Update()
    {
        healthText.text = "Health: " + Ball.health;
    }

}
