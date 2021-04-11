using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
			SoundManager.PlaySound("Fire");
            Debug.Log("Ziurek kur eini");
            Countt.scores -= 1;
		}
    }
}
