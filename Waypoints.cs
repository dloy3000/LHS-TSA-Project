using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject waypointSystem;
    private Transform self;
    private Transform[] waypoints;
    private Transform targetWaypoint;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        self = waypointSystem.transform;

        Transform[] children = self.GetComponentsInChildren<Transform>();
        waypoints = children;

        targetWaypoint = waypoints[0];
        Debug.Log("Loaded!");

        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        followWayPoint();
        nextWaypoint();
    }

    //void addWayPoint(int index)
    //{
        //Debug.Log(transform.GetChild(index).ToString());
        //waypoints.Add(transform.GetComponentInChildren<Transform>());
        //Debug.Log("The waypoint " + transform.GetChild(index).ToString() + " has been added!");
    //}

    void followWayPoint()
    {
        //Vector2 rotationVector = transform.position - targetWaypoint.position;

        transform.LookAt(targetWaypoint, transform.up);
    }

    void nextWaypoint()
    {
        if (transform == targetWaypoint)
        {
            targetWaypoint = waypoints[index + 1];
        }
    }
}
