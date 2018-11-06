using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveTest : MonoBehaviour
{
    public Rigidbody2D car;

    public float walkSpeed;

    private Vector3 movementVector;

    private float horizontalF, verticalF;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        horizontalF = Input.GetAxisRaw("Horizontal") * walkSpeed;

        verticalF = Input.GetAxisRaw("Vertical") * walkSpeed;

        car.AddForce(new Vector2(horizontalF * walkSpeed, verticalF * walkSpeed));
    }
}
