using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CléDeux : MonoBehaviour
{
    public GameObject keyUI;
    [SerializeField] private Animator targetAnimator;
    public bool animationKeyDeux;
    public GameObject actualKeyII;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("keyII"))
        {
            {
                keyUI.SetActive(true);
                animationKeyDeux = true;
                targetAnimator.SetBool("gotem", true);
                Debug.Log("Activation");
            }
            Debug.Log("Le Script de Clé passe");
        }
    }
}