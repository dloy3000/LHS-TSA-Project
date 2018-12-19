using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public int neededObj;
    private Transform door;

    private Animator anim;

    private bool isOpen;
    private Collider2D self;

    private void Start()
    {
        anim = GetComponent<Animator>();
        self = GetComponent<Collider2D>();
        door = GetComponent<Transform>();

        isOpen = false;

        anim.SetBool("isOpen", isOpen);
    }

    public void openDoor(Inventory playerInventory)
    {
        if (playerInventory.doesContain(InventoryObj.getObj(neededObj)))
        {
            Debug.Log(playerInventory.doesContain(InventoryObj.getObj(neededObj)));
            playerInventory.removeObj(InventoryObj.getObj(neededObj)); //Removes the object from inventory

            self.enabled = false;
            isOpen = true;

            anim.SetBool("isOpen", isOpen);
            Debug.Log("Opened door.");
        }

        Debug.Log(playerInventory.doesContain(InventoryObj.getObj(neededObj)));
    }
}
