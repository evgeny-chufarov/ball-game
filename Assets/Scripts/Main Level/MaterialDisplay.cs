using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MaterialDisplay : MonoBehaviour
{

    public Text materialText;

    void Update()
    {
        if (Ball.isMetal)
        {
            materialText.text = "Material: " + "Metal";
        }
        else if (Ball.isWood)
        {
            materialText.text = "Material: " + "Wood";
        }
    }

}
