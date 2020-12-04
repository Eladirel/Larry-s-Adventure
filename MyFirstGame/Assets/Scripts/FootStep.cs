using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    // Arreglo de archivos de audio
    public AudioClip[] sounds;
    
    private AudioSource audioSource;
    
    private void Awake() {
        audioSource = GetComponent<AudioSource>();    
    }
    public void Step(){
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }

    public AudioClip GetRandomClip(){
        return sounds [UnityEngine.Random.Range(0, sounds.Length)];
    }
}
