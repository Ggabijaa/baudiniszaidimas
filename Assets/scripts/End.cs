using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;
public class Player
{
    public string name { get; set; }
    public double score { get; set; }

    public Player()
    {
        this.name = null;
        this.score = 0;
    }
    public Player(string name, double score)
    {
        this.name = name;
        this.score = score;
    }
}

public class End : MonoBehaviour
{
    public Text f1;
    public Text f2;
    public Text f3;
    public Text f4;

    public void sortt(Player[] players, int o)
    {
        for (int i = 0; i < o - 1; i++)
            for (int j = 0; j < o - i - 1; j++)
                if (players[j].score < players[j + 1].score)
                {
                    // swap temp and arr[i]
                    Player temp = players[j];
                    players[j] = players[j + 1];
                    players[j + 1] = temp;
                }
        
    }

    public void Leader()
    {
        Player[] players = new Player[200];
        string path = "Assets/Resources/data.txt";
        int i = 0;
        using(StreamReader reader = new StreamReader(path))
        {

            string line;
            //pav = reader.ReadLine();
            while((line = reader.ReadLine()) != null)
            {
                 string[] parts = line.Split(';');
                 string pavadinimas = parts[0];
                 double dydis = double.Parse(parts[1]);
                 players[i] = new Player(pavadinimas, dydis);
                 i++;
            }
           
        }

        sortt(players,i);
        f1.text = players[0].name +"   "+ players[0].score.ToString();
        f2.text = players[1].name+"   "+ players[1].score.ToString();
        f3.text = players[2].name+"   "+ players[2].score.ToString();
        f4.text = players[3].name+"   "+ players[3].score.ToString();
    }

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
