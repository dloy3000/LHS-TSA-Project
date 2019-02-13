using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioClip song;

    public AmbientMusic playerSource;

    public void sendSong()
    {
        playerSource.getSong(song);
    }
}
