using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionScript : MonoBehaviour
{
	 public ParticleSystem particle;
 
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
			this.gameObject.GetComponent<Renderer>().enabled = false;
 			particle.Play();
			Debug.Log("Opa ikrito");
            SoundManager.PlaySound("collect");
			PlayerController.current +=10;
            //Countt.scores += 1;
            Destroy(this.gameObject, 0.5f);
        }
    }
}