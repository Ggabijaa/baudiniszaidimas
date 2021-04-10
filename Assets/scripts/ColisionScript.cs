using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionScript : MonoBehaviour
{
	
 
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("Opa ikrito");
            SoundManager.PlaySound("collect");
            Countt.scores += 1;
        }
    }
}