using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class finishcont : MonoBehaviour
{
    public Text f1;
    public static bool test = false;
    private int g = 1;
    void Update()
    {
        if (test && g == 1)
        {
            f1.text = "Score: "+ PlayerController.Score;
            g++;
        }
    }


    public void MainMenu()
    {
        
        SceneManager.LoadScene(0);
    }
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
