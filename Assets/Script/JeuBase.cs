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
    public TextMeshProUGUI niveau;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI points;
    public TextMeshProUGUI bouteillesNBR;


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

        points.text =  0 + " Points";
        bouteillesNBR.text = 0 + "";
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            niveau.text = "Intérieur de la Maison";
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            niveau.text = "Extérieur de la Maison";
        }
    }

    
}
