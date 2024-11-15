using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform orientation;
    public Rigidbody rb;
    private CharacterController controller;
    private Vector3 playerVelocity;
    public bool isGrounded;
    public bool groundPlay;
    public float jumpForce = 1.0f;
    public float playerSpeed = 5.0f;
    public float rotationSpeed = 2.0f;
    public float jumpHeight = 1.0f;
    public float verticalMovement;
    public float horizontalMovement;

    private bool isGravityFlipped = false; // Tracks gravity flip state

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        rb.GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Player Movement Code
        Vector3 moveInput = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical")
        );

        // Get movement direction relative to orientation
        Vector3 move = orientation.TransformDirection(moveInput);

        // Adjust movement direction based on gravity flip state
        if (isGravityFlipped)
        {
            move.y *= -1; // Flip vertical movement direction
        }

        // Move the player
        controller.Move(move * Time.deltaTime * playerSpeed);

        // Rotate the player to face the direction of movement
        if (moveInput != Vector3.zero)
        {
            Quaternion rotationTarget = Quaternion.LookRotation(move);
            Vector3 targetEuler = rotationTarget.eulerAngles;

            // Lock X and Z rotations, adjust X for gravity state
            targetEuler.x = isGravityFlipped ? 180f : 0f; // Flip X-axis for upside down
            targetEuler.z = 0f;

            gameObject.transform.rotation = Quaternion.Slerp
                (
                gameObject.transform.rotation,
                Quaternion.Euler(targetEuler),
                rotationSpeed * Time.deltaTime
                );
        }

        // Apply movement
        controller.Move(move * Time.deltaTime * playerSpeed);

        // Apply gravity direction based on gravity state
        groundPlay = controller.isGrounded;
        if (groundPlay && playerVelocity.y <= 0)
        {
            playerVelocity.y = 0f;
        }
        playerVelocity = orientation.forward * verticalMovement + orientation.right * horizontalMovement;
    }

    public void SetGravityState(bool flipped)
    {
        // Updates the gravity flip state
        isGravityFlipped = flipped;
    }
}
