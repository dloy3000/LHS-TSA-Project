using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLine : MonoBehaviour
{
    private Quest prerequisite;
    private Quest successive;
    private InitialQuest initialQuest;
    private ActiveQuest activeQuest;

    private void Start()
    {
        initialQuest = GetComponent<InitialQuest>();
        prerequisite = initialQuest.returnInitial();

        successive = prerequisite.getNextQuest();
        activeQuest = GetComponent<ActiveQuest>();
    }

    public void heirarchy()
    {
        if (prerequisite.completion() == true)
        {
            prerequisite = successive;
            successive = successive.getNextQuest();

            activeQuest.setActiveQuest(prerequisite);
        }
    }


}
