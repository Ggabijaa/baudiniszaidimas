using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public AudioSource Main;
    public AudioSource Pau;
    public AudioSource Sho;

    public void music1()
    {
        Main.Pause();
        Pau.Play();
    }
    public void music2()
    {
        Main.Pause();
        Sho.Play();
    }

    public void Pause()
    {
        
        Time.timeScale = 0f;
    }
}
