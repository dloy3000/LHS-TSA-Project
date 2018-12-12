using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObj : MonoBehaviour
{
    private string objName;
    private int objID;
    private string description;

    public InventoryObj(string name, string descript, int ID)
    {
        objName = name;
        description = descript;
        objID = ID;
    }

    public string ReturnName()
    {
        return objName;
    }

    public int ReturnID()
    {
        return objID;
    }

    public string ReturnDescription()
    {
        return description;
    }

    void changeID(int newID)
    {
        objID = newID;
    }

    public static InventoryObj getObj(int objID)
    {
        return InventoryRegistry.Registry(objID);
    }
}
