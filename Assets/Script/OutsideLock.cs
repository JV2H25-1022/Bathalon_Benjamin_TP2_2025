using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class OutsideLock : MonoBehaviour
{
    // Start is called before the first frame update
    public CléOne key;
    public RetireTrash scoreCurrent;
    public GameObject door;
    public CléOne keyUI;
    public GameObject refusKey;
    public GameObject refusScore;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("door"))
        {
            {
                if(key.animationKeyOne == false)
                {
                    Invoke("NoKey", 0f);
                    Invoke("NoKeyGone", 3f);
                    Debug.Log("Pas de Clé");
                }

                else if(scoreCurrent.Score <= 5)
                {
                    Invoke("NoScore", 0f);
                    Invoke("NoScoreGone", 3f);
                    Debug.Log("Score Bas");
                }

                else
                {
                    keyUI.keyUI.SetActive(false);
                    door.SetActive(false);
                    Debug.Log("Porte Off");
                }
            }
            Debug.Log("Le Script de porte passe");
        }
    }

    public void NoScore()
    {
        refusScore.SetActive(true);
        Debug.Log("Y'a le script qui s'active btw");
    }

    public void NoScoreGone()
    {
        refusScore.SetActive(false);
    }
    public void NoKey()
    {
        refusKey.SetActive(true);
    }

    public void NoKeyGone()
    {
        refusKey.SetActive(false);
    }

}
