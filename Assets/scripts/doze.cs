using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doze : MonoBehaviour
{
    public GameObject Main;
    public GameObject End;
    public AudioSource audioScr1;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;
            audioScr1.Stop();
            Main.SetActive(false);
            End.SetActive(true); 
        }
    }
}
