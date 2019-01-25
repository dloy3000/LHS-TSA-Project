using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialQuest : MonoBehaviour
{
    public Quest initialQuest;
    private ActiveQuest activeQuest;

    public Quest returnInitial()
    {
        return initialQuest;
    }
}
