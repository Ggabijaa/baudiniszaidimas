using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
           
            PlayerController.currentHealt -= 105;
            Debug.Log("kill");
        }

        
    }
}
