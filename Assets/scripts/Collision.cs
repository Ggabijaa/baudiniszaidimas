using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collision : MonoBehaviour
{
public float time = 0;
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
			time += Time.deltaTime;
			if(time > 0.1){
			Countt.scores -= 1;
			SoundManager.PlaySound("fire");
			time = 0;
			Debug.Log("Ziurek kur eini");
			Debug.Log(time);
			}
		}
    }
}
