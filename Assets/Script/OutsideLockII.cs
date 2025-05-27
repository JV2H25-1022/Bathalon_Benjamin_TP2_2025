using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class OutsideLockII : MonoBehaviour
{
    // Start is called before the first frame update
    public CléDeux keyII;
    public RetireTrash scoreLive;
    public PorteFin doorOut;
    public CléOne keyUITwo;
    public OutsideLock refusKeys;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("doorII"))
        {
            {
                if (keyII.animationKeyDeux == false)
                {
                    Invoke("NoKeyII", 0f);
                    Invoke("NoKeyGoneII", 3f);
                    Debug.Log("Pas de Clé");
                }


                else
                {
                    keyUITwo.keyUI.SetActive(false);
                    doorOut.dahDoor.SetActive(false);
                    Debug.Log("Porte Off");
                }
            }
            Debug.Log("Le Script de porte passe");
        }
    }
    public void NoKeyII()
    {
        refusKeys.refusKey.SetActive(true);
    }

    public void NoKeyGoneII()
    {
        refusKeys.refusKey.SetActive(false);
    }

}