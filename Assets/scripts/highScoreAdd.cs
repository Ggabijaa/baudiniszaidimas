using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class highScoreAdd : MonoBehaviour
{
    
    
    public InputField iField;
    
        
    public void write()
    {
        string path = "Assets/Resources/data.txt";
        string name;
        float score;
        name = iField.text;
        score = PlayerController.Score;
        WriteString(path, name, score);

    }

    public void WriteString(string path, string name, float score)
    {
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(name +";"+ Mathf.Abs(score));
        writer.Close();

        //Re-import the file to update the reference in the editor
        //AssetDatabase.ImportAsset(path); 
        //TextAsset asset = Resources.Load("test");

        //Print the text from the file
        //Debug.Log(asset.text);
    }
}

