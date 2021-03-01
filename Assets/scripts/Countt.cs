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
        countText.text = "Gyvybes: ";
        scores = 0;
    }


    void Update()
    {
        countText.text = "Gyvybes: "+scores;
    }
}
