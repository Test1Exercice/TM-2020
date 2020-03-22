using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ballTag")) // when collide with the gameObject with the tag ballTag
        {
            GameObject.Find("ballObj").GetComponent<ball>().Reset();           // Run all Functions of Reset in their classes
            GameObject.Find("gameManagerObj").GetComponent<manager>().Reset(); // Run all Functions of Reset in their classes
            GameObject.Find("player1").GetComponent<paddle>().Reset();         // Run all Functions of Reset in their classes
        }
    }
}
