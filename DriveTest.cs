using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveTest : MonoBehaviour
{
    public Rigidbody2D car;

    public float walkSpeed, handling, dragF, frictionC, maxVeloF;

    private Vector2 currentV;

    private Vector3 movementVector;

    private float horizontalF, verticalF;

    public Animator carAnimator;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        horizontalF = Input.GetAxisRaw("Horizontal") * walkSpeed;

        verticalF = Input.GetAxisRaw("Vertical") * walkSpeed;

        car.AddForce(car.transform.up * verticalF * walkSpeed);

        currentV = car.velocity;

        if (verticalF != 0)
        {
            car.AddTorque(-1 * handling * horizontalF);
        }

        ApplyDrag();
        MaxSpeed();
    }

    void ApplyDrag()
    {
        car.AddForce(-1*((car.velocity * car.mass) * (frictionC)));
    }

    void MaxSpeed()
    {
        bool veloX = false;
        bool veloY = false;

        if (currentV.x > maxVeloF)
        {
            veloX = true;
        }

        if (currentV.y > maxVeloF)
        {
            veloY = true;
        }

        if (veloX == true && veloY == true)
        {
            car.velocity = new Vector2(maxVeloF, maxVeloF);
        }

        else if (veloX == true && veloY == false)
        {
            car.velocity = new Vector2(maxVeloF, car.velocity.y);
        }

        else if (veloX == false && veloY == true)
        {
            car.velocity = new Vector2(car.velocity.x, maxVeloF);
        }
    }
}
