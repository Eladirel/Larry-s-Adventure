using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiHelper : MonoBehaviour
{
    public GameObject pnlPrincipal;
    public GameObject pnlInstrucciones;
    public GameObject pnlInstrucciones2;

    public void IniciarPartida(){
        Time.timeScale = 1;
        GameManager.instance.isPaused = false;
        HealtManager.instanceHM.ResetVidas();
        GameManager.instance.ChangeScenes("08-EscenarioJuego-09-Laberinto-C");
    }

    public void Instrucciones1(){
        pnlPrincipal.SetActive(false);
        pnlInstrucciones.SetActive(true);
    }

    public void SiguienteInstrucciones(){
        pnlInstrucciones.SetActive(false);
        pnlInstrucciones2.SetActive(true);
    }

    public void AnteriorInstrucciones(){
        pnlInstrucciones.SetActive(true);
        pnlInstrucciones2.SetActive(false);
    }

    public void VolverPrincipal(){
        pnlPrincipal.SetActive(true);
        pnlInstrucciones.SetActive(false);
        pnlInstrucciones2.SetActive(false);
    }

    public void CerrarAplicacion(){
        Application.Quit(); 
    }
}
