using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D player;
    public float walkSpeed, interactDist;

    public Button interactButton;
    public Text inventoryBar; //Test obj

    public Animator anim;
    private Inventory playerInventory;
    private Interact interaction;

    private bool isWalking;
    private bool walkingUp, walkingDown, walkingRight, walkingLeft;

    private float horizontalF, verticalF;
    private Vector2 playerDirection, tempDirection;

    // Use this for initialization
    void Start()
    {
        isWalking = false;
        interaction = GetComponent<Interact>();
        playerInventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalF = Input.GetAxisRaw("Horizontal") * walkSpeed;

        verticalF = Input.GetAxisRaw("Vertical") * walkSpeed;

        player.velocity = new Vector2(horizontalF * walkSpeed, verticalF * walkSpeed);

        tempDirection = new Vector2(horizontalF, verticalF);

        if (tempDirection == new Vector2(0, 0))
        {
            tempDirection = playerDirection;
        }

        playerDirection = tempDirection;

        Animate(verticalF, horizontalF);

        InteractPlayer();
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

    void InteractPlayer() //Change to add interactions with StaticObj
    {
        InventoryObj obj;

        RaycastHit2D hit = Physics2D.Raycast(player.transform.position, playerDirection, interactDist);

        if (hit.collider != null)
        {
            if (hit.collider.transform.gameObject.GetComponent<InventoryObj>())
            {
                interactButton.gameObject.SetActive(true);

                obj = hit.collider.transform.gameObject.GetComponent<InventoryObj>();

                int objID = obj.ReturnID();
            }

            else if(hit.collider.transform.gameObject.GetComponent<StaticObj>())
            {
                interactButton.gameObject.SetActive(true);
            }

            if (Input.GetKey(KeyCode.Z) && interactButton.enabled == true)
            {
                //playerInventory.addObj(obj);
                //Interact()

                Interact.getTarget(hit.collider.gameObject, playerInventory);
            }
        }

        else
        {
            interactButton.gameObject.SetActive(false);
        }
    }
}