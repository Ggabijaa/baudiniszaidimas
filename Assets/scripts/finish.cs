using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finish : MonoBehaviour
{
    public GameObject Main;
    public GameObject End;
    public AudioSource audioScr1;
    public Text f1;
   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            finishcont.test = true;
            Time.timeScale = 0f;
            audioScr1.Stop();
            Main.SetActive(false);
            End.SetActive(true); 
        }
    }
}
