using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelFinal : MonoBehaviour
{
    public GameObject imagenFondo;
    public GameObject imagenFinal;
    private bool menuFinalActivo;
    
    void Update() {
        if (GameManager.instance.finalPanel && !menuFinalActivo)
        {  
            mostrarPanel();
            menuFinalActivo = true;
        }    
    }

    public void mostrarPanel(){
        imagenFondo.SetActive(true);
        imagenFinal.SetActive(true);
        Time.timeScale = 0;
        GameManager.instance.isPaused = true;
    }
    public void VolverTitulo(){
        menuFinalActivo = false;
        imagenFondo.SetActive(false);
        imagenFinal.SetActive(false);
        Time.timeScale = 1;
        GameManager.instance.isPaused = false;
        GameManager.instance.ChangeScenes("Portada"); 
        GameManager.instance.finalPanel = false;
    }
}
