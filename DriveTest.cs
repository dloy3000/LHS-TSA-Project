using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveTest : MonoBehaviour
{
    public Rigidbody2D car;

    public float acceleration, handling, dragF, frictionC, maxVeloF;

    private Vector2 currentV;

    private Vector3 movementVector;

    private float horizontalF, verticalF;

    private bool passMax;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalF = Input.GetAxisRaw("Horizontal") * acceleration;

        verticalF = Input.GetAxisRaw("Vertical") * acceleration;

        car.AddForce((car.transform.up * verticalF * acceleration));

        currentV = car.velocity;

        if (verticalF != 0)
        {
            car.AddTorque(-1 * handling * horizontalF);
            //car.transform.Rotate(car.transform.right * horizontalF * handling);
        }

        MaxSpeed();
        ApplyDrag();
    }

    void ApplyDrag()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
        //car.AddForce(-1 * ((car.velocity.normalized * car.mass) * (10 * frictionC)));
        //Debug.Log("You pressed space.");
        //}


        ////
        if (passMax || verticalF == 0)
            car.AddForce(-1 * ((car.velocity * car.mass)));

        else if (passMax == false)
        {
            car.AddForce(-1 * (car.velocity.normalized * car.mass * (car.velocity.sqrMagnitude / (1000 * frictionC))));
            car.AddForce(-1 * (car.transform.right * car.velocity.magnitude));
        }
        ////


        //car.AddForce(-1 * ((car.velocity.normalized * car.mass * frictionC)));

        //car.AddForce((-1 * (((car.velocity.x + car.velocity.y) * car.transform.right * car.mass) * (10 * frictionC))));
    }

    void MaxSpeed()
    {
        if (car.velocity.x > maxVeloF)
            car.velocity = new Vector2(maxVeloF, car.velocity.y);

        if (car.velocity.y > maxVeloF)
            car.velocity = new Vector2(car.velocity.x, maxVeloF);

        if (car.velocity.x < (-1 * maxVeloF))
            car.velocity = new Vector2(-1 * maxVeloF, car.velocity.y);

        if (car.velocity.y < (-1 * maxVeloF))
            car.velocity = new Vector2(car.velocity.x, -1 * maxVeloF);

        if (car.velocity.magnitude > maxVeloF)
            passMax = true;

        else
            passMax = false;
    }

    public Vector2 returnVelo()
    {
        return currentV;
    }
}