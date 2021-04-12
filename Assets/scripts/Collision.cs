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
				if (PlayerController.current > 0)
				{
					PlayerController.current -=10;
				}
				else
				{
					PlayerController.currentHealt -=10;
				}

			SoundManager.PlaySound("fire");
			time = 0;
			Debug.Log(PlayerController.current);
			}
		}
    }
}
