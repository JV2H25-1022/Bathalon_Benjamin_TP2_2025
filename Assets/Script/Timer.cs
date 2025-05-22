using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public TextMeshProUGUI textTimer;

    // Update is called once per frame
    void Update()
    {

        textTimer.text = timer.ToString() + " Secondes";

        if(SceneManager.GetActiveScene().buildIndex != 0 && SceneManager.GetActiveScene().buildIndex != 3)
        {
            timer -= Time.deltaTime;
        }


    }
}
