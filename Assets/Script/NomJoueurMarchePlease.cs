using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.Rendering;

public class NomJoueurMarchePlease : MonoBehaviour
    
{
    // Start is called before the first frame update
    public TextMeshProUGUI nompick;

    public void Start()
    {
        nompick.text = PlayerPrefs.GetString("nomPris");
        Debug.Log(PlayerPrefs.GetString("nomPris"));
    }
}
