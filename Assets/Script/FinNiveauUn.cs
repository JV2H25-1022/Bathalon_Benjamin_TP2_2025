using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveauUn : MonoBehaviour
{
    public GameObject trashUn;
    public GameObject trashDeux;
    public GameObject keyed;
    public GameObject endDoor;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
            trashUn.SetActive(true);
            trashDeux.SetActive(true);
            keyed.SetActive(true);
            endDoor.SetActive(true);
        }
        Debug.Log("Bonk");
    }
}
