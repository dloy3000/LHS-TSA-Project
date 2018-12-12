using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private List<InventoryObj> inventory;

    public Canvas menu;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void addObj(int objID)
    {
        inventory.Add(InventoryObj.getObj(objID));
    }
}
