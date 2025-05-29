using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GrassCollect : MonoBehaviour
{
    public GameObject GrassUI;
    public GameObject actualGrass;
    public AudioSource collect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("grass"))
        {
            {
                GrassUI.SetActive(true);
                actualGrass.SetActive(false);
                Debug.Log("Activation");
                collect.Play();
            }
            Debug.Log("Le Script de Grass passe");
        }
    }
}
