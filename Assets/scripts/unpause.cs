using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class unpause : MonoBehaviour
{
    public AudioSource S;
    public AudioSource P;
    public void UnPause()
    {
        S.Stop();
        P.Play();
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
