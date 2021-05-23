using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnamyHealth : MonoBehaviour
{
    public static int hp = 100;
    public static int dam = 50;
    public static int coins = 100;
    void OnTriggerEnter2D(Collider2D col) {
        
        if (col.gameObject.tag == "bulet")
        {
           
            damage();
        }
    }

   void damage()
    {
        
        hp = hp - dam;
        if (hp == 0)
        {
            SoundManager.PlaySound("monster");
            hp = 100;
            Destroy(this.gameObject);
            Countt.scores += coins;
            //PlayerController.kills += 200;
        }
    }
}
