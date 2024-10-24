using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform orientation;//player
    public float camFollowDelay = 0.125f;
    public float camRotationDelay = 0.02f;
    public Vector3 offset;
    //public Vector3 rotationOffset;

    // Start is called before the first frame update
    void Start()
    {

    }//end start

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = orientation.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(this.transform.position, playerPosition, camFollowDelay);
        this.transform.position = smoothedPosition;

        //the camera will face the same direction as the player
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, orientation.rotation, camRotationDelay);


    }//end update
}//end class
