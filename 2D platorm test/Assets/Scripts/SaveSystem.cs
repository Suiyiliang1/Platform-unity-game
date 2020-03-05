using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

  public static void SaveScore(ScoreboardScore ScoreboardData)
    {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/ScoreData.json";
        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            ScoreData data = new ScoreData(ScoreboardData);
            formatter.Serialize(stream, data);
        }      
    }

    public static ScoreData LoadScore()
    {
        string path = Application.persistentDataPath + "/ScoreData.json";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                ScoreData Data = formatter.Deserialize(stream) as ScoreData;              
                return Data;
            }         
            
        }
        else
        {
            Debug.Log("Error!");
            return null;
        }
    }
}
