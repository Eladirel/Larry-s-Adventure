using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject imagenFondo;
    public GameObject gameOver;
    private bool menuGOActivo;

    // Update is called once per frame
    void Update()
    {
        if (HealtManager.instanceHM.GetVidas() == 0 && !menuGOActivo)
        {
            menuGOActivo = true;
            ActivarGameOver();
        }
    }

    public void ActivarGameOver(){
        imagenFondo.SetActive(true);
        gameOver.SetActive(true);
        Time.timeScale = 0;
        GameManager.instance.isPaused = true;
    }

    public void VolverTitulo(){
        menuGOActivo = false;
        imagenFondo.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1;
        GameManager.instance.isPaused = false;
        GameManager.instance.ChangeScenes("Portada"); 
    }
}
