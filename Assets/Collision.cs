using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Health"){
            Destroy(this.gameObject);
            Debug.Log("Paliete");
        }
	
    }
}
