using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeColider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Player") {
            SoundManager.PlaySound("slimy");
        }
    }
}
