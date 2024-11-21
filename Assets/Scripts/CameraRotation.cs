using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This script will allow the player to rotate the camera with their mouse
*/

public class CameraRotation : MonoBehaviour
{
    private Vector2 turn;
    private float sensitivity = 0.5f;

    private void Update()
    {
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}//end camera rotation class
