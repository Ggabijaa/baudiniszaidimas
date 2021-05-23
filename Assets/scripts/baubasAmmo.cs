using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baubasAmmo : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 20;
    public static int damagehealth = 5;
    public Rigidbody2D rb;
    public static bool face = false;

    // Use this for initialization
    void Start () 
    {
        if (face)
        {
            ShootRight();
        }
        else
        {
            ShootLeft();  
        }

        
        
        
    }

    void ShootLeft()
    {
        rb.velocity = transform.right * speed *-1;
    }
    void ShootRight()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.gameObject.tag);
        if (hitInfo.gameObject.tag != "Enamy")
        {
		   
            Destroy(gameObject);

        }

	
        if (hitInfo.gameObject.tag == "Player" )
        {
            if (PlayerController.current > 0)
            {
                PlayerController.current -= damage;
                SoundManager.PlaySound("koss");
            }
            else
            {
                PlayerController.currentHealt -= damagehealth;
                SoundManager.PlaySound("koss");
            }

            if (PlayerController.currentHealt <= 0)
            {
                        
            }
            Destroy(gameObject);

        }
	
    }
}
