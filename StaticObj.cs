using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObj : MonoBehaviour
{
    public string objName;
    //private int staticID;
    public GameObject target;
    public int effectType;

    public void ActivateStatic(Inventory playerInventory)
    {
        if (effectType == 0) //Opening, disabling of doors
        {
            OpenDoor door = GetComponent<OpenDoor>();

            door.openDoor(playerInventory);
        }

        //if (effectType == 1) --activate some object
    }
}
