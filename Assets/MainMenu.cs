using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider mSlider1;
    public Slider mSlider2;
    // Start is called before the first frame update
    public void PlayGame()
    {
        PlayerController.ammo = 20;
        PlayerController.coins = 0;
        PlayerController.current = 100;
        PlayerController.currentHealt = 100;
        PlayerController.time = 0f;
        PlayerController.Score = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetOptions()
    {
        float master = 0f;
        float ef = 0f;
        audioMixer.GetFloat("Master",out master);
        audioMixer.GetFloat("effects",out ef);
        mSlider1.value = master;
        mSlider2.value = ef;
    }
}