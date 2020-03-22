using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("ballTag")) // when collide with the gameObject with the tag ballTag
        {
            GameObject.Find("gameManagerObj").GetComponent<manager>().Player1Scored(); // Call function to Increment Score in manger Class!

        }
    }

}
