using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    void Start() {
        if (HealtManager.instanceHM.buscarHealUsado(this.gameObject.name))
        {
            Destroy(gameObject);
        }    
    }

    // Método que se ejecuta cuando este objeto interseca otro objeto en el juego.
    private void OnTriggerEnter(Collider other)
    {
        // Consultamos si el objeto que interseca tiene la etiqueta del jugador.
        if(other.CompareTag("Player"))
        {
            if(HealtManager.instanceHM.AddVidas()){
                Destroy(gameObject);
                HealtManager.instanceHM.addHealUsado(this.gameObject.name);
            }
        }
    }
}
