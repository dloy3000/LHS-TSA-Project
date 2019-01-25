using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    private int id;

    private string questName;

    private string objective; //Description of Quest

    private Inventory targetObj; //List of items that need to be gathered

    private bool isActivatable; //Tests whether the quest can be interacted with

    private bool isComplete; //Checks for quest completion

    private Quest nextQuest;

    public Quest(string name, string descript, Inventory targets)
    {
        questName = name;
        objective = descript;
        targetObj = targets;
    }

    public string returnName()
    {
        return questName;
    }

    public string returnDescript()
    {
        return objective;
    }

    public Inventory returnTargets()
    {
        return targetObj;
    }

    public bool startQuest()
    {
        return isActivatable;
    }

    public bool completion()
    {
        return isComplete;
    }

    public Quest getNextQuest()
    {
        return nextQuest;
    }

    //Function to check if quest conditions are completed?
}
