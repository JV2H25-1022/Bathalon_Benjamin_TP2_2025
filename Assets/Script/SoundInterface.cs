using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundInterface : MonoBehaviour
{
    // Start is called before the first frame update
    public static SoundInterface instance;
    public GameObject sound;
    public GameObject settings;
    void Awake()
    {

        if (instance == null)
        {

            instance = this;

            DontDestroyOnLoad(gameObject);
        }

        else
        {

            Destroy(gameObject);
        }

    }

     void Start()
    {
        settings.SetActive(true);
    }

    public void openMenu()
    {
        sound.SetActive(true);
    }

    public void closeMenu() 
    { 
        sound.SetActive(false);
    }

}
