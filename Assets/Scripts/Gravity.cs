using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private float gravity = -0.1f;
    private CharacterController CRR;
    private Vector3 Velocity;
    // Start is called before the first frame update
    void Start()
    {
        CRR = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Velocity.y += gravity * Time.deltaTime;
        CRR.Move(Velocity * Time.deltaTime);
    }
}
