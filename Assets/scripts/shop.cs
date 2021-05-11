using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{ 
	public AudioSource audioScr1;
	public AudioSource audioScr2;
    public void UnPause()
    {
	    audioScr1.Stop();
	    audioScr2.Play();
        Time.timeScale = 1f;
    }


	public void speed()
	{

	
	int price = 5;
	if(Countt.scores >= price)
	{
	Countt.scores -= price;
	float add = PlayerController.Speed / 4f;
	PlayerController.Speed += add;
	}
	
	}


	public void jump()
	{
	
	int price = 5;
	if(Countt.scores >= price)
	{
	Countt.scores -= price;
	float add = PlayerController.Jump / 4f;
	PlayerController.Jump += add;
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
		if(Countt.scores >= price)
		{
			Countt.scores -= price;
			
			weapon.startTimeBtwShots /= 2f;
		}
	}
}
