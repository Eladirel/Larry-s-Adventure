using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public bool puertaAbrir;

    [Range(0f, 4f)]
    [Tooltip("Speed for door opening, degrees per sec")]
    public float OpenSpeed = 3f;

    // Hinge
    [HideInInspector]
    public Rigidbody rbDoor;
    HingeJoint hinge;
    JointLimits hingeLim;
    float currentLim;

    //sound
    public AudioClip sound;
    private AudioSource audioSource;

    void Start()
    {
        rbDoor = GetComponent<Rigidbody>();
        hinge = GetComponent<HingeJoint>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "DoorY" && GameManager.instance.llaveYaz ||
        this.gameObject.name == "DoorL" && GameManager.instance.llaveLab ||
        this.gameObject.name == "DoorT" && GameManager.instance.llaveTal)
            puertaAbrir = true;
        
        if (this.transform.rotation.z > 22f)
            audioSource.PlayOneShot(sound); 
        
    }

    private void FixedUpdate() // door is physical object
    {
        if (puertaAbrir)
        {
            currentLim = 85f;
        }
        else
        {
            // currentLim = hinge.angle; // door will closed from current opened angle
            if (currentLim > 1f)
                currentLim -= .5f * OpenSpeed;
        }

        // using values to door object
        hingeLim.max = currentLim;
        hingeLim.min = -currentLim;
        hinge.limits = hingeLim;
    }
}
