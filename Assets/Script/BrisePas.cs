using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BrisePas : MonoBehaviour
{
    // Start is called before the first frame update
    public static BrisePas instance;
    public AudioSource musique;
    void Awake()
    {
       
        if (instance == null)
        {
           
            instance = this;
            
            DontDestroyOnLoad(gameObject);
        }
       
        else
        {
            
            Destroy(gameObject);
        }

    }

    public void STFU(){
        if(SceneManager.GetActiveScene().buildIndex == 3){
            musique.Stop();
        }
        else{
            musique.Play();
        }
    }
}
