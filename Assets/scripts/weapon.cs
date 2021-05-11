using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {


    public GameObject projectile;
    public Transform shotPoint;

    public static float timeBtwShots;
    public static float startTimeBtwShots = 0.5f;

    private void Update()
    {
       
        if (timeBtwShots <= 0)
        {

            if (Input.GetButtonDown("Submit"))
            {
if(CountAmoo.scores>=1){
               // Instantiate(shotEffect, shotPoint.position, Quaternion.identity);
                
                //Instantiate(projectile, shotPoint.position, shotPoint.rotation);
                fireRocket();
                timeBtwShots = startTimeBtwShots;
				SoundManager.PlaySound("soots");
				CountAmoo.scores -= 1;
            }
        }
}
        else {
            timeBtwShots -= Time.deltaTime;
        }

       
    }
    void fireRocket() 
    {
       
            Instantiate(projectile, shotPoint.position, Quaternion.Euler(new Vector3(0, 0, 0))); 
        
    }
}