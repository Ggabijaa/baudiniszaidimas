using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Enamy : MonoBehaviour
{

    
	public static int damage = 10;
    public static int damagehealth = 5;
    public static float speed = 3f;
   	public static float range = 15f;
    
    public Transform player;
    
    Rigidbody2D body2D;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization

    void Update ()
    {
        //Debug.Log(hp);
        float dist = Vector2.Distance(transform.position, player.position);
       
        if (dist < range)
        {
            Chase();

        }
        else
        {
            Stop();
        }

        


    }
    void Chase()
    {
        if (transform.position.x < player.position.x)
        {

            body2D.velocity = new Vector2(speed, 0);
        }
        else
        {
            body2D.velocity = new Vector2(-speed, 0);
        }
    }

    void Stop()
    {
        body2D.velocity = new Vector2(0, 0);
    }

    private float time = 0;
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            time += Time.deltaTime;
                if(time > 0.5){
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

                    PlayerController.current -= damage;
                
                time = 0;
            }
        }
    }

}