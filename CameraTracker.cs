using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    private Camera main;
    public GameObject target;

	// Use this for initialization
	void Start ()
    {
        main = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        main.transform.position = target.transform.position;
	}
}
