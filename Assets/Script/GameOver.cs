using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Timer timed;
    public RetireTrash scored;
    public TextMeshProUGUI endScore;
    public TextMeshProUGUI endTimer;
    public GameObject centralJoueur;

    // Update is called once per frame
    void Update()
    {

        endTimer.text = timed.textTimer.text;
        endScore.text = scored.Score.ToString();


    }

    public void EndGame()
    {
        Destroy(centralJoueur);
        SceneManager.LoadScene(0);

    }
}
