using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public static int findObject(InventoryObj targetObj) //returns the id of the target object
    {
        Debug.Log("-------------");
        Debug.Log(targetObj.ReturnName());
        Debug.Log(targetObj.ReturnDescription());
        Debug.Log(targetObj.ReturnID());
        return targetObj.ReturnID();
    }
}
