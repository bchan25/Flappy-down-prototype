using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float downForce;           
    private bool isDead = false;            

 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Don't allow control if the bird has died.
        if (isDead == false)
        {
            //Look for input to trigger a "flap".
            if (Input.GetMouseButtonDown(0))
            {
            
                //...zero out the birds current y velocity before...
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, -downForce));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Zero out the bird's velocity
        rb.velocity = Vector2.zero;
        // If the bird collides with something set it to dead...
        isDead = true;
    }
}
