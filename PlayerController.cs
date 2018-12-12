using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D player;

    public float walkSpeed, interactDist;
    
    public Button interactButton;

    public Animator anim;

    private bool isWalking;

    private bool walkingUp, walkingDown, walkingRight, walkingLeft; 

    private float horizontalF, verticalF;

    private Vector2 playerDirection, tempDirection;

    //testLine
    public LineRenderer laser;

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

        playerDirection = tempDirection;

        tempDirection = new Vector2(horizontalF, verticalF);

        if (tempDirection == new Vector2(0, 0))
        {
            tempDirection = playerDirection;
        }

        Interact();
    }

    void Animate(float verticalF, float horizontalF)
    {
        float currentVector = horizontalF + verticalF;

        if (currentVector != 0)
            isWalking = true;

        if (verticalF > 0)
        {
            walkingUp = true;
            walkingDown = false;
            walkingRight = false;
            walkingLeft = false;
        }

        else if (verticalF < 0)
        {
            walkingUp = false;
            walkingDown = true;
            walkingRight = false;
            walkingLeft = false;
        }

        else if (horizontalF > 0)
        {
            walkingUp = false;
            walkingDown = false;
            walkingRight = true;
            walkingLeft = false;
        }

        else if (horizontalF > 0)
        {
            walkingUp = false;
            walkingDown = false;
            walkingRight = false;
            walkingLeft = true;
        }

        else if (currentVector == 0)
            isWalking = false;

        anim.SetBool("isWalking", isWalking);
    }

    void Interact()
    {
        GameObject targetObj;

        RaycastHit2D playerIntRange = Physics2D.Raycast(player.transform.position, playerDirection, interactDist);

        targetObj = playerIntRange.transform.gameobject;

        if (targetObj.tag == "Interactable")
        {
          interactButton.setActive(true);

          if (Input.GetKeyCode(KeyCode.Space))
          {
            InventoryObj.Interact(targetObj);
          }
        }

        else
        {
          interactButton.setActive(false)
        }
    }
}
