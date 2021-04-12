using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class durys : MonoBehaviour
{
    private Animator animator;
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //this.gameObject.GetComponent<Renderer>().enabled = false;
            Debug.Log("Atsidaro durys negaliu įeiti");
            animator.SetBool("opens", true);
            //SoundManager.PlaySound("Vit");
            //Countt.scores += 1;
        }
    }
}
