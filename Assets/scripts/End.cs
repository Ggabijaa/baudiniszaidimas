using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;
class Player
{
    public string name { get; set; }
    public int score { get; set; }

    public Player()
    {
        this.name = null;
        this.score = 0;
    }
    public Player(string name, int score)
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
    public void Leader()
    {
        int i = 0;
        Player[] players = new Player[5];
        string[] data = new string[5];
        string path = "Assets/Resources/data.txt";
        using(StreamReader reader = new StreamReader(path))
        {

            string line;
            //pav = reader.ReadLine();
            while((line = reader.ReadLine()) != null && (i < 4))
            {
                //string[] parts = line.Split(';');
                data[i] = line;
                //pavadinimas = parts[0];
                
                //dydis = double.Parse(parts[1]);
                i++;
            }
           
        }

        f1.text = data[0];
        f2.text = data[1];
        f3.text = data[2];
        f4.text = data[3];
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    
}
