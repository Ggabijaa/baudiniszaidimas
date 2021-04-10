using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Debug.Log("dead");
            SoundManager.PlaySound("slimy2");
            SceneManager.LoadScene("caves");
        }
    }
}
