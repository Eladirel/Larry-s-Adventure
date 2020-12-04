// Universidad Estatal a Distancia
// Introducción a Unity
// Autor: Lic. Juan Pablo Navarro Fennell

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]

public class GetKey : MonoBehaviour
{

    public GameObject texto;

    // Miembros de clase protegidos
    protected Renderer render;

    //sound
    public AudioClip sound;
    public AudioSource audioSource;

    // Método que se ejecuta cuando aparece este objeto en pantalla
    void Start()
    {
        render = GetComponent<Renderer>();
        if (GameManager.instance != null)
        {
            if(this.gameObject.name == "Llave Yaz" && GameManager.instance.llaveYaz ||
            this.gameObject.name == "Llave Tal" && GameManager.instance.llaveTal ||
            this.gameObject.name == "Llave Lab" && GameManager.instance.llaveLab)
            {
                Destroy(gameObject);
                Destroy(texto);
            }
        }
    }

    // Rutina que se ejecuta cada vez que se dibuja una nueva imagen en pantalla.
    void Update()
    {
        transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
    }

    // Método que se ejecuta cuando este objeto interseca otro objeto en el juego.
    private void OnTriggerEnter(Collider other)
    {
        // Consultamos si el objeto que interseca tiene la etiqueta del jugador.
        if (other.CompareTag("Player")) 
        {
            if (GameManager.instance != null)
            {
                if (this.gameObject.name == "Llave Yaz")
                    GameManager.instance.llaveYaz =  true;

                if (this.gameObject.name == "Llave Lab")
                    GameManager.instance.llaveLab =  true;

                if (this.gameObject.name == "Llave Tal")
                    GameManager.instance.llaveTal =  true;
                
                audioSource.PlayOneShot(sound);
                Destroy(gameObject);
                Destroy(texto);
            }
            else
            {
                Debug.LogError("Singleton no configurado");
            }
        }
    }
}
