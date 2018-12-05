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

        ApplyDrag();
        //MaxSpeed();
    }

    void ApplyDrag()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
            //car.AddForce(-1 * ((car.velocity * car.mass) * (10 * frictionC)));
            //Debug.Log("You pressed space.");
        //}

        //else
        car.AddForce(-1 * ((car.velocity * car.mass) * (frictionC)));

        car.AddRelativeForce(car.transform.up * car.velocity);
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
            if (currentV.x < 0)
                car.velocity = new Vector2(maxVeloF * -1, maxVeloF);

            if (currentV.y < 0)
                car.velocity = new Vector2(maxVeloF, maxVeloF * -1);

            else
                car.velocity = new Vector2(maxVeloF, maxVeloF);
        }

        else if (veloX == true && veloY == false)
        {
            if (currentV.x < 0)
                car.velocity = new Vector2(maxVeloF * -1, car.velocity.y);

            else
                car.velocity = new Vector2(maxVeloF, car.velocity.y);
        }

        else if (veloX == false && veloY == true)
        {
            if (currentV.x < 0)
                car.velocity = new Vector2(car.velocity.x, maxVeloF * -1);

            else
                car.velocity = new Vector2(car.velocity.x, maxVeloF);
        }
    }

    public Vector2 returnVelo()
    {
        return currentV;
    }
}
