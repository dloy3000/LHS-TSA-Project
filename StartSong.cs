using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSong : MonoBehaviour
{
    private MusicTrigger trigger;
    private bool sent;

    private void Start()
    {
        sent = false;
    }

    void Update()
    {
        if (sent == false)
        {
            trigger = GetComponent<MusicTrigger>();

            trigger.sendSong();

            sent = true;
        }
    }
}
