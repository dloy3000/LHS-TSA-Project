using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveQuest : MonoBehaviour
{
    private Quest activeQuest;

    public void setActiveQuest(Quest newQuest)
    {
        activeQuest = newQuest;
    }
}
