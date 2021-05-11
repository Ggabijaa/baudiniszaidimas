using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class unpause : MonoBehaviour
{
    public AudioSource audioScr1;
    public AudioSource audioScr2;
    public void UnPause()
    {
        audioScr1.Stop();
        audioScr2.Play();
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
