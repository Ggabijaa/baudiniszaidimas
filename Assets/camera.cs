using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject durys_3;
    public GameObject durys_2;
    public Animator animator;

    void Start()
    {
        durys_2.GetComponent<Renderer>().enabled = false;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
                
                animator.SetBool("first", true);
                SoundManager.PlaySound("eee");
                Invoke(nameof(StopCutScene), 3f);
                Invoke(nameof(durys), 1f);
        } 
    }

    void StopCutScene()
    {
        animator.SetBool("first", false);
    }
    void durys()
    {
        durys_3.GetComponent<Renderer>().enabled = false;
        durys_2.GetComponent<Renderer>().enabled = true;
    }
    
    
}
