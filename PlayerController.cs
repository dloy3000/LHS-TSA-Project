using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D player;

    public Animator anim;

    public bool isWalking;

    public float walkSpeed;

    private float horizontalF, verticalF;

    // Use this for initialization
    void Start()
    {
        isWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalF = Input.GetAxisRaw("Horizontal") * walkSpeed;

        verticalF = Input.GetAxisRaw("Vertical") * walkSpeed;

        player.velocity = new Vector2(horizontalF * walkSpeed, verticalF * walkSpeed);

        Animate(verticalF, horizontalF);
    }

    void Animate(float verticalF, float horizontalF)
    {
        float currentVector = horizontalF + verticalF;

        if (currentVector != 0)
            isWalking = true;

        else if (currentVector == 0)
            isWalking = false;

        anim.SetBool("isWalking", isWalking);
    }

    void Interact()
    {

    }
}