using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class JeuBase : MonoBehaviour
{

    public static JeuBase instance;
    public TextMeshProUGUI nomjoueur;
    
    
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
}
