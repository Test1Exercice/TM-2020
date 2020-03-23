using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    public Vector3 startPosition;

    private float movement;

    void Start()
    {
        startPosition = transform.position; // store first position
    }

    // Update is called once per frame
    void Update()
    {
        // Acess this Vertical Input in Edit > Input > Axes > Vertical
       
        movement = Input.GetAxisRaw("Vertical");   // default by unity W and S keys and other properties, Returns the value of the virtual axis, in the range of -1...1 
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);   // set velocity of paddle
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;          // Reset velocity
        transform.position = startPosition;  // Reset position to the initial one
    }
}
