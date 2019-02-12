using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    private Inventory inventory; //Player's inventory

    public GameObject inventoryScreen; //Panel containing inventory images

    public List<Texture2D> inventoryImgSet;
    public Image[] inventoryDisplay;
    //Inventory Images, is set equal to the images from the inventory on an Update

    private int index = 0; //Used to find position within the inventory
    private int previousNum = 1; //Used to ensure that the images on the inventory display only update when changed, to reduce lag 

    public int maxIndex;

    void Start()
    {
        inventory = GetComponent<Inventory>();
        inventoryDisplay = GetComponentsInChildren<Image>();
    }

    void Update()
    {
        if (inventoryScreen.activeInHierarchy == true)
        {
            getInputs();

            if (index != previousNum)
            {
                UpdateInvScreen(index);
                Debug.Log("The inventory panel has been updated!");
            }

            previousNum = index;
        }
    }

    void UpdateInvScreen(int indent)
    {
        InventoryObj[] invObj = inventory.returnComponents();

        for (int i = 0; i <= invObj.Length; i++)
        {
            Texture2D tex = invObj[i + indent].returnImage();
            inventoryDisplay[i].sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        }
    }

    void getInputs()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
            index -= 1;

        if (Input.GetKeyUp(KeyCode.DownArrow))
            index += 1;

        if (index > maxIndex)
            index = 0;

        if (index < 0)
            index = maxIndex;
    }
}

