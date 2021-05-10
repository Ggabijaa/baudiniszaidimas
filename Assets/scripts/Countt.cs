using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countt : MonoBehaviour
{
    public static int scores;
    public Text countText;
    void Start()
    {
        
        
        countText.text = "Coins: ";
        scores = PlayerController.coins;
    }

    void Update()
    {
        countText.text = "Coins: " + scores;
        Coins(scores);
    }

    void Coins(int scores)
    {
        PlayerController.coins = scores;
    }
}
