using UnityEngine;

public class playerMovement : MonoBehaviour
{

    // This is a reference to the Rigidbody component
    public Rigidbody rb;

    // Creating a force variables
    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;

    // FixedUpdate is called once per frame
    // It helps in adding physics
    void FixedUpdate()
    {
        // rb.AddForce(0,0,forwardForce * Time.deltaTime);
        // Time.deltaTime returns the amount of seconds since the computer drew the last frame
        // So, if it did 10 frames in 1 second, it will return 0.1. If it did 20 frames, it will return 0.05
        // Thus, what it basically does is that, on slower PCs, it will run faster.
        // Hence, it provides consistency to the movements regardless of the performance of the device

        // Add sideways force according to keyboard inputs
        if(Input.GetKey("right")){
            rb.AddForce(sideWaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("left")){
            rb.AddForce(-sideWaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // if(Input.GetKey("up")){
            // rb.AddForce(0, 0, forwardForce* Time.deltaTime, ForceMode.VelocityChange);
        // }

        // if(Input.GetKey("down")){
        //     rb.AddForce(0, 0, -forwardForce* Time.deltaTime, ForceMode.VelocityChange);
        // }

        rb.AddForce(0, 0, forwardForce* Time.deltaTime, ForceMode.VelocityChange);

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
}
