using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountAmoo : MonoBehaviour
{
    public static int scores;
    public Text countText;
    void Start()
    {
        
        
        countText.text = "Ammo: ";
        scores = PlayerController.ammo;
    }

    void Update()
    {
        countText.text = "Ammo: " + scores;
        Coins(scores);
    }

    void Coins(int scores)
    {
        PlayerController.ammo = scores;
    }
    
}
