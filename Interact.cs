using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    //Determine whether target object is static or inv
    public static void getTarget(GameObject obj, Inventory playerInventory)
    {
        if (obj.GetComponent<InventoryObj>())
        {
            playerInventory.addObj(getInventoryObject(obj));

            obj.SetActive(false);
        }

        else if (obj.GetComponent<StaticObj>())
        {
            StaticObj staticObj = getStaticObject(obj);

            staticObj.ActivateStatic(playerInventory);
        }
    }
    
    public static InventoryObj getInventoryObject(GameObject obj)
    {
        InventoryObj objInv = obj.GetComponent<InventoryObj>();

        return objInv;
    }

    public static StaticObj getStaticObject(GameObject obj)
    {
        StaticObj objStatic = obj.GetComponent<StaticObj>();

        return objStatic;
    }
}
