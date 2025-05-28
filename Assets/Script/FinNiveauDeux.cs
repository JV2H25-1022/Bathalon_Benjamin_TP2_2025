using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveauDeux : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UIFull;
    public GameObject joueur;
    public GameObject CanvasFin;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
            UIFull.SetActive(false);
            joueur.SetActive(false);
            CanvasFin.SetActive(true);

        }
        Debug.Log("Bonk");
    }
}
