using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NomJoueur : MonoBehaviour
{

    public TextMeshProUGUI nomfinal;
    public TextMeshProUGUI nomchoix;
    // Start is called before the first frame update
   public void ValiderNom(string nouveauNom)
    {
        PlayerPrefs.SetString("nomChoix", nouveauNom);
        nomfinal.text = nouveauNom;
    }
}
