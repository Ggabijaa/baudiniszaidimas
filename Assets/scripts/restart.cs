using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour
{
    public void Restart()
    {
        PlayerController.ammo = 20;
        PlayerController.coins = 0;
        PlayerController.current = 100;
        PlayerController.currentHealt = 100;
        PlayerController.time = 0f;
        PlayerController.Score = 0f;
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
