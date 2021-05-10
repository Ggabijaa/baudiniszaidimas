using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start () 
	{
		if(PlayerController.facingRight)
			{
		ShootLeft();
			}
	else
        ShootRight();
    }
	void ShootRight()
	{
		rb.velocity = transform.right * speed;
	}
	void ShootLeft()
	{
		rb.velocity = transform.right * speed *-1;
	}
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
	if(hitInfo.name != "ED")
	{
	Destroy(gameObject);
	}
    }
	
}