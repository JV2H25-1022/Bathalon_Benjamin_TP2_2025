using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NomJoueur : MonoBehaviour
{

    public TextMeshProUGUI nomchoix;
    public TextMeshProUGUI nomfinal;
    
    // Start is called before the first frame update
   public void ValiderNom(string nouveauNom)
    {
        PlayerPrefs.SetString("nomPris", nouveauNom);

        nomfinal.text = nouveauNom;
        Debug.Log(PlayerPrefs.GetString("nomPris"));
    }
}
