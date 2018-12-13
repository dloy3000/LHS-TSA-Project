using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //private List<InventoryObj> inventory;

    private InventoryObj[] inventory = new InventoryObj[99999];

    public Canvas menu;

    public void addObj(InventoryObj obj)
    {
        //InventoryObj obj = InventoryObj.getObj(objID);
        //Debug.Log("The name of this item is " + obj.ReturnName());
        //inventory.Add(obj);

        inventory[0] = obj;
        Debug.Log(inventory[0]);
    }

    public static Inventory returnInventory(Inventory myInventory)
    {
        return myInventory;
    }
}
