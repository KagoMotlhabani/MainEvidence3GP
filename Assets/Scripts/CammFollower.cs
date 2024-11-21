using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CammFollower : MonoBehaviour
{
    public Transform camTarget;
    public float plerp = 0.02f;
    public float rlerp = 0.01f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position,plerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation,rlerp);
    }
}
