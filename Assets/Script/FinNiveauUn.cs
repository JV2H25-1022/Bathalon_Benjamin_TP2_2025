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
    public GameObject lawmmower;
    public AudioSource transition;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transition.Play();
            SceneManager.LoadScene(2);
            trashUn.SetActive(true);
            trashDeux.SetActive(true);
            keyed.SetActive(true);
            endDoor.SetActive(true);
            lawmmower.SetActive(true);

        }
        Debug.Log("Bonk");
    }
}
