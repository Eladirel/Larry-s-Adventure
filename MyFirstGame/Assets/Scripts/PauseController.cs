using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject imagenFondo;
    public GameObject imagenPausa;
    private bool menuPausaActivo;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !menuPausaActivo)
        {
            menuPausaActivo = true;
            ActivarPausa();
        }
    }

    public void ActivarPausa(){
        imagenFondo.SetActive(true);
        imagenPausa.SetActive(true);
        Time.timeScale = 0;
        GameManager.instance.isPaused = true;
    }

    public void DesactivarPausa(){
        menuPausaActivo = false;
        imagenFondo.SetActive(false);
        imagenPausa.SetActive(false);
        Time.timeScale = 1;
        GameManager.instance.isPaused = false;
    }

    public void VolverAlMenuPrincipal(){
        Time.timeScale = 1;
        GameManager.instance.ChangeScenes("Portada"); 
    }
}
