using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerHandler : MonoBehaviour
{
    public Transform player;
    private Transform door;

    private SpriteRenderer doorRend;
    private SpriteRenderer playerRend;

    // Use this for initialization
    void Start ()
    {
        door = GetComponent<Transform>();

        playerRend = player.gameObject.GetComponent<SpriteRenderer>();
        doorRend = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Door sorting layer is " + doorRend.sortingOrder);
        Debug.Log("Player sorting layer is " + playerRend.sortingOrder);

        if (player.position.y > door.position.y)
            doorRend.sortingOrder = playerRend.sortingOrder + 1;

        else
            doorRend.sortingOrder = playerRend.sortingOrder - 1;
    }
}
