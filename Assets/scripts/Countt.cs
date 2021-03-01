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
        
        
        countText.text = "Gyvybės: ";
        scores = 0;
    }

    void Update()
    {
        countText.text = "Gyvybės: "+scores;
        Health(scores);
    }

    void Health(int scores)
    {
        if (scores < 3)
        {
            countText.color = Color.red;
        }
        else
        {
            countText.color = Color.green;
        }
    }
}
