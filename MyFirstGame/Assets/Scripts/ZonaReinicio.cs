﻿// Universidad Estatal a Distancia
// Introducción a Unity
// Autor: Lic. Juan Pablo Navarro Fennell

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]

public class ZonaReinicio : MonoBehaviour
{
    // Miembros de clase pública.
    public Transform destino;

    //sound
    public AudioClip sound;
    public AudioSource audioSource;

    // Método que se ejecuta cuando este objeto interseca otro objeto en el juego.
    private void OnTriggerEnter(Collider other)
    {
        // Consultamos si el objeto que interseca tiene la etiqueta del jugador.
        if(other.CompareTag("Player"))
        {
            // Se reubica el avatar del jugador en otra ubicación de la escena.
            other.transform.position = destino.position;

            //reducir vidas de personaje
            if (!this.CompareTag("Portal"))
                HealtManager.instanceHM.DownVidas();
            
            if (this.CompareTag("Portal"))
                audioSource.PlayOneShot(sound);
        }
    }
}