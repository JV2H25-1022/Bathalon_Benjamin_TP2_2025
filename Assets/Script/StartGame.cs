using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource startsound;
    public void StartGamer()
    {
        SceneManager.LoadScene(1);
        startsound.Play();
    }
}
