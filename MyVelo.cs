using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyVelo : MonoBehaviour
{
    public DriveTest car;
    private Vector2 currentVelo;
    private Text veloText;

	// Use this for initialization
	void Start ()
    {
        veloText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        currentVelo = car.returnVelo();

        float refinedVelo = Mathf.Sqrt((currentVelo.x * currentVelo.x) + (currentVelo.y * currentVelo.y));

        refinedVelo = Mathf.Round(refinedVelo * 2.23694f);

        veloText.text = refinedVelo.ToString() + "mph";
    }
}
