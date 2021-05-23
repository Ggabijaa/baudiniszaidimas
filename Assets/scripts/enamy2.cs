using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class enamy2 : MonoBehaviour
{

    public GameObject projectile;
    public Transform shotPoint;
    public Transform shotPoint2;
    public static float timeBtwShots;
    public static float startTimeBtwShots = 3f;
    
    
    public static int damage = 20;
    public static int damagehealth = 10;
    public static float speed = 2f;
    public static float range = 15f;
    public static float ShotingRange = 15f;
    
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

        if (dist < ShotingRange)
        {
            if (transform.position.x < player.position.x)
            {
                if (timeBtwShots <= 0)
                {
                    fireRocket2();
                    timeBtwShots = startTimeBtwShots;
                    SoundManager.PlaySound("soots");
                }
                else {
                    timeBtwShots -= Time.deltaTime;
                }
            }
            else
            {
                if (timeBtwShots <= 0)
                {
                    fireRocket();
                    timeBtwShots = startTimeBtwShots;
                    SoundManager.PlaySound("soots");
                }
                else {
                    timeBtwShots -= Time.deltaTime;
                }
            }

            
        }



    }
    void fireRocket() 
    {
       
        Instantiate(projectile, shotPoint.position, Quaternion.Euler(new Vector3(0, 0, 0))); 
        
    }
    void fireRocket2() 
    {
       
        Instantiate(projectile, shotPoint2.position, Quaternion.Euler(new Vector3(0, 0, 0))); 
        
    }
    void Chase()
    {
        if (transform.position.x < player.position.x)
        {
            enamyAmmo.face = true;
            body2D.velocity = new Vector2(speed, 0);
        }
        else
        {
            enamyAmmo.face = false;
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