using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryRegistry : MonoBehaviour
{
    private static InventoryObj myObj;

    public static InventoryObj Registry(int objID)
    {
        InventoryObj invObject = myObj;
        string objName; 

        string objDescript; 


        if (objID == 0) //If there is a rarity system, do it so that each nth number is x rarity
        {
            objName = "Electrolytic Capacitor";
            objDescript = "A small capacitor that stores pulses of energy. Has high capacitance but isn't the most efficient storage device...";
            invObject = new InventoryObj(objName, objDescript, objID);
        }

        else if (objID == 1) //If there is a rarity system, do it so that each nth number is x rarity
        {
            objName = "Ceramic Capacitor";
            objDescript = "A small capacitor that stores pulses of energy. Has low and somewhat unstable capacitance, but are efficient enough to have a myriad of uses.";
            invObject = new InventoryObj(objName, objDescript, objID);
        }

        else if (objID == 2) //If there is a rarity system, do it so that each nth number is x rarity
        {
            objName = "Key Card: Clearance Level C";
            objDescript = "A security key card with the lowest level of clearance. Grants access to warehouses and rooms available to low-ranking factory workers.";
            invObject = new InventoryObj(objName, objDescript, objID);
        }

        return invObject;
    }
}
