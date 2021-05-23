using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{ 
	public AudioSource S;
	public AudioSource P;
	public Text speedas;
	public Text jumpas;
	public Text shoot;
	private int amountshoting = 3;
	private int amountjump = 2;
	private int amountspeed = 3;
    public void UnPause()
    {
	    S.Stop();
	    P.Play();
        Time.timeScale = 1f;
    }


	public void speed()
	{

	
	int price = 5;
	if(Countt.scores >= price && amountspeed > 0)
	{
	Countt.scores -= price;
	float add = PlayerController.Speed / 4f;
	PlayerController.Speed += add;
	amountspeed--;
	speedas.text ="Left: " + amountspeed;
	}
	
	}


	public void jump()
	{
	
	int price = 5;
	if(Countt.scores >= price && amountjump > 0)
	{
	Countt.scores -= price;
	float add = PlayerController.Jump / 4f;
	PlayerController.Jump += add;
	amountjump--;
	jumpas.text ="Left: " + amountjump;
	}
	}


	public void armor()
	{
	int price = 5;
	if(Countt.scores >= price)
	{
	Countt.scores -= price;
	int add = PlayerController.current + 10;
	if(PlayerController.current == PlayerController.Max)
	{
	
	}
	else if(add >PlayerController.Max)
	{
	PlayerController.current = PlayerController.Max;

	}
	else
	{
	PlayerController.current += 10;
	}
	}
	
	}


	public void healths()
	{
	int price = 5;
	if(Countt.scores >= price)
	{
	Countt.scores -= price;
	int add = PlayerController.currentHealt + 10;
	if(PlayerController.currentHealt == PlayerController.MaxHealt)
	{
	
	}
	else if(add >PlayerController.MaxHealt)
	{
	PlayerController.currentHealt = PlayerController.MaxHealt;

	}
	else
	{
	PlayerController.currentHealt += 10;
	}
	}
	}
	public void ammo()
	{
	
		int price = 5;
		if(Countt.scores >= price)
		{
			Countt.scores -= price;
			CountAmoo.scores += 10;
		}
	}
	public void shooting()
	{
	
		int price = 5;
		if(Countt.scores >= price && amountshoting >0)
		{
			Countt.scores -= price;
			weapon.startTimeBtwShots /= 2f;
			amountshoting--;
			shoot.text = "Left: " + amountshoting;
		}
	}
}
