using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class en : MonoBehaviour
{

    public static float hp = 100;
    public float speed = 1f;
    public float range = 3f;
    
    public Transform player;
    
    Rigidbody2D body2D;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization

    void Update ()
    {

        float dist = Vector2.Distance(transform.position, player.position);
        //Debug.Log(dist);
        if (dist < range)
        {
            Chase();

        }
        else
        {
            Stop();
        }

        if (hp <= 0)
        {
            SoundManager.PlaySound("monss");	
            Countt.scores += 100;
            Destroy(this.gameObject);
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

    public float time = 0;
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            time += Time.deltaTime;
            if(time > 0.5){
                if (PlayerController.current > 0)
                {
                    PlayerController.current -=10;
                }
                else
                {
                    PlayerController.currentHealt -=10;
                }

                SoundManager.PlaySound("koss");
                time = 0;
                Debug.Log(PlayerController.current);
            }
        }
    }

}