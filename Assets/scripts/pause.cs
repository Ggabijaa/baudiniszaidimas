using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public AudioSource audioScr1;
    public AudioSource audioScr2;
    public AudioSource audioScr3;

    public void music1()
    {
        audioScr1.Pause();
        audioScr2.Play();
    }
    public void music2()
    {
        audioScr1.Pause();
        audioScr3.Play();
    }

    public void Pause()
    {
        
        Time.timeScale = 0f;
    }
}
