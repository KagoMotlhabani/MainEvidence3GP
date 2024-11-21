using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform orientation; // Reference to the orientation object
    public CharacterController controller; // Reference to the CharacterController
    private float sprintSpeed = 5f;
    private Vector3 playerVelocity; // Tracks movement velocity
    private bool isGrounded;
    private int gravityMultiplier = -1; // Default gravity is downward
    private float gravity = 9.8f; // Gravitational force
    public float playerSpeed = 5.0f; // Movement speed
    public float jumpHeight = 2.0f; // Jump height

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        HandleMovement();
        ApplyGravity();
    }

    private void HandleMovement()
    {
        // Get input for movement
        Vector3 moveInput = new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical")
        );

        // Convert input to world direction using orientation
        Vector3 move = orientation.TransformDirection(moveInput);

        // Move the player
        controller.Move(move * Time.deltaTime * playerSpeed);

        // Rotate the player towards movement direction
        if (moveInput != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 3f);
        }

        // Apply sprint speed
        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * Time.deltaTime * sprintSpeed);

        }
    }

    private void ApplyGravity()
    {
        // Check if player is on the ground
        isGrounded = controller.isGrounded;

        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f; // Reset vertical velocity when grounded
        }

        // Apply gravity
        playerVelocity.y += gravityMultiplier * gravity * Time.deltaTime;

        // Move the player vertically
        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void SetGravityDirection(int multiplier)
    {
        // Update gravity multiplier
        gravityMultiplier = multiplier;

        // Reset vertical velocity for a smooth gravity flip
        playerVelocity.y = 0f;
    }
}
