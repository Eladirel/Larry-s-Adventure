using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtManager : MonoBehaviour
{
    public static HealtManager instanceHM;
    //Sonidos 
    public AudioClip[] sounds;
    public AudioClip sonidoCura;
    private AudioSource audioSource;
    //frames de invulnerabilidad
    public float iFramesLenght;
    private float iFramesCounter;
    //vidas
    public int vidas;
    public int maxVidas;
    //lista de curas usadas
    private List<string> curas = new List<string>();

    private void Awake()     
    {         
        if(instanceHM == null)          
        {             
            instanceHM = this;             
            DontDestroyOnLoad(this.gameObject);         
        }         
        else         
        {             
            Destroy(this);         
        }

        audioSource = GetComponent<AudioSource>(); 
    } 

    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
        maxVidas = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (iFramesCounter > 0) iFramesCounter -= Time.deltaTime;
    }

    public bool AddVidas()     
    {        
        if (vidas < maxVidas)
        {
            vidas += 1;  
            audioSource.PlayOneShot(sonidoCura);
            return true;
        }
        else
        {
            return false;
        }
    }  
    
    public void ResetVidas()     
    {         
        vidas = 3;
        curas.Clear();
    }

    public int GetVidas()
    {
        return vidas;
    }

    public void DownVidas()     
    {        
        if (vidas > 0)
        {
            if (iFramesCounter <= 0)
            {
                vidas -= 1;
                AudioClip clip = GetRandomClip();
                audioSource.PlayOneShot(clip);
            }   
        }
    }

    public AudioClip GetRandomClip(){
        return sounds [UnityEngine.Random.Range(0, sounds.Length)];
    }

    public void addHealUsado(string heal){
        curas.Add(heal);
    }

    public bool buscarHealUsado(string heal){
        for (int i = 0; i < curas.Count; i++)
        {
            if (curas[i] == heal)
            {
                return true;
            }
        }
        return false;
    }
}
