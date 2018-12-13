using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignObjID : MonoBehaviour
{
    public int ID;
    private InventoryObj invObject;

	void Start ()
    {
        invObject = GetComponent<InventoryObj>();
        invObject.changeID(ID);

        Debug.Log(invObject.ReturnName());
        Debug.Log(invObject.ReturnDescription());
	}
}
