using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetireTrash : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _Can;
    public float Score;
    public JeuBase Pointage;
    public JeuBase bouteilles;
    public ObtentionCan Grabbed;



    void Update()
    {

        Pointage.points.text = Score.ToString() + " Points";
        bouteilles.bouteillesNBR.text = Grabbed.Yoinked.ToString();


    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("trash"))
        {
            Score += Grabbed.Yoinked;
            Grabbed.Yoinked = 0;
            Debug.Log("Grabbed");
            Pointage.points.text = Score.ToString() + " Points";
            bouteilles.bouteillesNBR.text = Grabbed.Yoinked.ToString();

        }
        Debug.Log("Touched");
    }



}
