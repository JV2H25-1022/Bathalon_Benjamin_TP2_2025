using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObtentionCan : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _Can;
    public float Yoinked;
    public JeuBase bouteilles;



    void Update()
    {

        bouteilles.bouteillesNBR.text = Yoinked.ToString();


    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Can"))
        {
            Yoinked += 1;
            other.gameObject.SetActive(false);
            Debug.Log("Grabbed");

        }
        Debug.Log("Touched");
    }

   

}
