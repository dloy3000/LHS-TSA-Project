using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private List<InventoryObj> inventory = new List<InventoryObj>();

    //private InventoryObj[] inventory = new InventoryObj[99999];

    public Text menu; //expiremental

    public void addObj(InventoryObj obj)
    {
        //Debug.Log("The name of this item is " + obj.ReturnName());

        Debug.Log("Targeting " + obj.ReturnName());

        inventory.Add(obj);
        Debug.Log(obj.ReturnName() + " added to inventory.");
    }

    public void removeObj(InventoryObj obj)
    {
        for (int i = 0; i < inventory.Count; i++)
            if (inventory[i].ReturnID() == obj.ReturnID())
            {
                inventory.Remove(inventory[i]);

                break;
            }
    }

    public bool doesContain(InventoryObj obj)
    {
        bool result = false;

        for (int i = 0; i < inventory.Count; i++)
            if (inventory[i].ReturnID() == obj.ReturnID())
                result = true;

        return result;
    }

    public Inventory returnInventory(Inventory myInventory)
    {
        return myInventory;
    }
}
