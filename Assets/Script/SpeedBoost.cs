using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    // Start is called before the first frame update
    public ThirdPersonController walk;
    public ThirdPersonController sprint;
    public GrassCollect UI;
    public GameObject grassDrop;
    public AudioSource SpeedUp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pot"))
        {
            {
                if(UI.GrassUI.activeSelf == true)
                {
                    SpeedUp.Play();
                    grassDrop.SetActive(true);
                    UI.GrassUI.SetActive(false);
                    walk.MoveSpeed = 3.5f;
                    sprint.SprintSpeed = 7f;
                    Debug.Log("Activation");
                }
                
            }
            Debug.Log("Le Script de Grass passe");
        }
    }
}
