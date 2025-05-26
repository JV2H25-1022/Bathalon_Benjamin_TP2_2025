using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CléOne : MonoBehaviour
{
    public GameObject keyUI;
    [SerializeField] private Animator targetAnimator;
    public bool animationKeyOne;
    public GameObject actualKey;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            {
                keyUI.SetActive(true);
                animationKeyOne = true;
                targetAnimator.SetBool("Gotcha", true);
                Debug.Log("Activation");
            }
            Debug.Log("Le Script de Clé passe");
        }
    }
}
