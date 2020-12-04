// Universidad Estatal a Distancia
// Introducción a Unity
// Autor: Lic. Juan Pablo Navarro Fennell

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour
{
    // Miembros de clase pública
    public float velocidadDesplamiento = 5;
    public float velocidadSalto = 5;
    public float distanciaRayo = 1.1f;
    public bool enElPiso;
    public Animator anim;

    // Miembros de clase protegidos
    protected Rigidbody cuerpoRigido;
    protected float velocodadX;
    protected float velocodadY;
    protected float velocodadZ;

    // Método que se ejecuta cuando aparece este objeto en pantalla
    void Start()
    {
        // Se obtiene la referencia al componente
        cuerpoRigido = GetComponent<Rigidbody>();
    }

    // Rutina que se ejecuta cada vez que se dibuja una nueva imagen en pantalla.
    void Update()
    {
        // Lectura de teclado
        velocodadX = Input.GetAxisRaw("Horizontal") * velocidadDesplamiento;
        velocodadZ = Input.GetAxisRaw("Vertical") * velocidadDesplamiento;

        if(Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0) 
        {            
            if(anim != null) anim.SetFloat("speed", 1f);        
        }
        else 
        {
            if(anim != null) anim.SetFloat("speed", 0f);
        }

        // Se aplica la velocidad
        cuerpoRigido.velocity = new Vector3(velocodadX, velocodadY, velocodadZ);
    }
}
