using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwap : MonoBehaviour
{
    private CharacterController CCR;
    private float grav = 9.8f;
    private Vector3 Velocity;
    private int gravityMultiplier = -1;
    private PlayerController playerController;

    private void Start()
    {
        CCR = GetComponent<CharacterController>();
        playerController = GetComponent<PlayerController>(); // Reference PlayerController
    }

    void Update()
    {
        // Check for space key press to flip gravity
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FlipGravity();
        }

        // Apply gravity each frame
        Velocity.y += gravityMultiplier * grav * Time.deltaTime;
        CCR.Move(Velocity * Time.deltaTime);
    }

    void FlipGravity()
    {
        // Flip the gravity direction
        gravityMultiplier *= -1;

        // Reset vertical velocity for a smooth transition
        Velocity.y = 0;

        if (gravityMultiplier == 1)
        {
            // Gravity is flipped
            transform.rotation = Quaternion.Euler(180f, transform.eulerAngles.y, 0f); // Upside-down
            playerController.SetGravityState(false); // Notify player controller

            // Update orientation to match flipped state
            playerController.orientation.localRotation = Quaternion.Euler(180f, 0f, 0f);
           
        }
        else
        {
            // Gravity is normal
            transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y, 0f); // Upright
            playerController.SetGravityState(true); // Notify player controller

            // Update orientation to normal
            playerController.orientation.localRotation = Quaternion.identity;
            
        }
    }
}
