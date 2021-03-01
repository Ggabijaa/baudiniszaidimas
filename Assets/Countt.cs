using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countt : MonoBehaviour
{
    public Text countText;
    void setCountText(int count)
    {
        countText.text = "Gyvybes: " + count.ToString();
    }
}
