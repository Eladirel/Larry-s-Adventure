using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isPaused)
        {
            audioSource.Pause();
        }
        else
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();    
            }
        }
    }
}
