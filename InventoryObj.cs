using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObj : MonoBehaviour
{
    private string objName;
    private int objID;
    private string description;
    private Texture2D objImage;

    public InventoryObj(string name, string descript, int ID, Texture2D image)
    {
        objName = name;
        description = descript;
        objID = ID;
        objImage = image;
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

    public Texture2D returnImage()
    {
        return objImage;
    }

    public void changeID(int newID)
    {
        objID = newID;

        InventoryObj obj = getObj(newID);

        objName = obj.ReturnName();
        description = obj.ReturnDescription();
    }

    public static InventoryObj getObj(int objID)
    {
        return InventoryRegistry.Registry(objID);
    }
}