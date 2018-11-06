using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTest : MonoBehaviour
{
    public Rigidbody2D player;

    public float walkSpeed;

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

        player.velocity = new Vector2(horizontalF * walkSpeed, verticalF * walkSpeed);
    }
}
