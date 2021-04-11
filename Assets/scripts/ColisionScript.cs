using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionScript : MonoBehaviour
{
	
 
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("Opa ikrito");
            SoundManager.PlaySound("collect");
            Countt.scores += 1;
        }
    }
}