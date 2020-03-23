using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ballTag")) // when collide with the gameObject with the tag ballTag
        {
            GameObject.Find("ball").GetComponent<Ball>().Reset();           // Run all Functions of Reset in their classes
            GameObject.Find("gameManagerObj").GetComponent<Manager>().Reset(); // Run all Functions of Reset in their classes
            GameObject.Find("player1").GetComponent<Paddle>().Reset();         // Run all Functions of Reset in their classes
        }
    }
}
