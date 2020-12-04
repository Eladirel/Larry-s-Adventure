using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool llaveYaz;
    public bool llaveLab;
    public bool llaveTal;
    private string _currentDoorId;
    public bool isPaused;
    public bool finalPanel;
    private string currentScene;

    void Update() {
        if (SceneManager.GetActiveScene().name != currentScene)
        {
            currentScene = SceneManager.GetActiveScene().name;
        }
    }

    private void Awake()     
    {         
        if(instance == null)          
        {             
            instance = this;      
            currentScene = SceneManager.GetActiveScene().name;       
            DontDestroyOnLoad(this.gameObject);         
        }         
        else         
        {             
            Destroy(this);         
        }   
    }
    
    public void ChangeScenes(string SceneName)     
    {         
        SceneManager.LoadScene(SceneName);
    }     
    
    public void SetDoor(string doorId) 
    {         
        _currentDoorId = doorId;     
    }
             
    public string GetDoor( ) 
    {    
        return _currentDoorId;     
    }
}