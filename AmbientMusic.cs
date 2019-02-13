using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientMusic : MonoBehaviour
{
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();

        source.loop = true;
    }

    private void Update()
    {
        
    }

    public void getSong(AudioClip areaAmbience)
    {
        source.clip = areaAmbience;

        source.PlayDelayed(0);
    }
}
