using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{

    public Text healthText;

    void Update()
    {
        healthText.text = "Health: " + Ball.health;
    }

}
