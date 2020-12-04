using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecesitasLlave : MonoBehaviour
{
    public GameObject texto;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (GameManager.instance != null)
            {
                if (this.gameObject.name == "NeedTal" && !GameManager.instance.llaveTal ||
                this.gameObject.name == "NeedYaz" && !GameManager.instance.llaveYaz ||
                this.gameObject.name == "NeedLab" && !GameManager.instance.llaveLab)
                    texto.transform.Translate(0f, 6f, 0f);           
                
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (GameManager.instance != null)
            {
                if (this.gameObject.name == "NeedTal" && !GameManager.instance.llaveTal ||
                this.gameObject.name == "NeedYaz" && !GameManager.instance.llaveYaz ||
                this.gameObject.name == "NeedLab" && !GameManager.instance.llaveLab)
                    texto.transform.Translate(0f, -6f, 0f);           
            }
        }
    }
}
