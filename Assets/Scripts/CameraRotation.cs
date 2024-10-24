using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This script will allow the player to rotate the camera with their mouse
*/

public class CameraRotation : MonoBehaviour
{
    public float Xsensetivity;
    public float Ysensetivity;
    public float Xrotation;
    public float Yrotation;
    public float sensitivity = -1f;
    public Transform orientation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }//end start

    // Update is called once per frame
    void Update()
    {

        //this attaches the camera to the curser and allows it to rotate when the mouse rotates

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * Xsensetivity;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * Ysensetivity;

        Vector3 rotate = new Vector3(mouseX, mouseY * sensitivity, 0);
        transform.eulerAngles = transform.eulerAngles - rotate;
        //Yrotation += mouseX;
        //Xrotation -= mouseY;
        //Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);

        //transform.rotation = Quaternion.Euler(Xrotation, Yrotation, 0);
        //orientation.rotation = Quaternion.Euler(0, Yrotation, 0);



    }//end update
}//end camera rotation class
