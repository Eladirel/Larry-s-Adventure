using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoPersonaje : MonoBehaviour
{
    public Transform personaje;
    public float distanciaX;     
    public float distanciaY;     
    public float distanciaZ;

    void Update( ) 
    {         
        // Ajusta la posición         
        this.transform.position = new Vector3(personaje.position.x + distanciaX, personaje.position.y + distanciaY,personaje.position.z + distanciaZ);         
        // Ajusta la rotación         
        this.transform.LookAt(personaje); 
    }
}
