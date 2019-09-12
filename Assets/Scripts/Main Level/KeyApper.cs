using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyApper : MonoBehaviour
{
    [SerializeField] private Image KeyImage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            KeyImage.enabled = true;
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
