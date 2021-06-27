using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float movementspeed;
    public Rigidbody2D rb;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");             //getting input for move left right
        movement.y = Input.GetAxis("Vertical");                  //getting input move up and down
       
       // rb.MovePosition(rb.position + movement * movementspeed * Time.fixedDeltaTime);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement *movementspeed*Time.fixedDeltaTime); // move player using rigidbody and by some amount of speed
    }
   
}
