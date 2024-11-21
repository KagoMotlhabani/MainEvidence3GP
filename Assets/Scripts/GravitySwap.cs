using UnityEngine;

public class GravitySwap : MonoBehaviour
{
    private int gravityMultiplier = -1; // Default gravity direction is downward
    private PlayerController playerController;

    private void Start()
    {
        // Get a reference to PlayerController
        playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        // Check for space key press to flip gravity
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FlipGravity();
        }
    }

    private void FlipGravity()
    {
        // Flip gravity multiplier
        gravityMultiplier *= -1;

        // Notify PlayerController of gravity flip
        playerController.SetGravityDirection(gravityMultiplier);

        // Rotate the player model based on gravity state
        if (gravityMultiplier == 1)
        {
            // Upside down
            transform.rotation = Quaternion.Euler(180f, transform.eulerAngles.y, 0f);
        }
        else
        {
            // Upright
            transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y, 0f);
        }
    }
}
