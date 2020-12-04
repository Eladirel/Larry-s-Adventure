using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampas : MonoBehaviour
{
    public AudioClip sound;
    
    private AudioSource audioSource;
    
    private void Awake() {
        audioSource = GetComponent<AudioSource>();    
    }
    public void Slash(){
        audioSource.PlayOneShot(sound);
    }
}
