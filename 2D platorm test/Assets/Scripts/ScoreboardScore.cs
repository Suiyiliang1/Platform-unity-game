using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

using TMPro;


public class ScoreboardScore : MonoBehaviour
{
    public TextMeshProUGUI Name, Name1, Name2, Score, Score1, Score2;
    public float tempscore;
    public bool Updateonce;

    // Start is called before the first frame update
    void Start()
    {
        Updateonce = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Updateonce == false)
        {
            
            LoadScore();
            tempscore = PlayerPrefs.GetFloat("Highscore");
            Debug.Log(tempscore);
            Debug.Log(Score.text);
            if ((tempscore) > float.Parse(Score.text))
            {
                Score2.text = Score1.text;
                Name2.text = Name1.text;
                Score1.text = Score.text;
                Name1.text = Name.text;
                Score.text = tempscore.ToString();
                Name.text = PlayerPrefs.GetString("name");
            }
            else if (tempscore > float.Parse(Score1.text))
            {
                Score2.text = Score1.text;
                Name2.text = Name1.text;
                Score1.text = tempscore.ToString();
                Name1.text = PlayerPrefs.GetString("name");
            }
            else if (tempscore > float.Parse(Score2.text))
            {
                Score2.text = tempscore.ToString();
                Name2.text = PlayerPrefs.GetString("name");
            }

            SaveScore();
            Updateonce = true;
        }
            
       
    }

    public void SaveScore()
    {
        SaveSystem.SaveScore(this);
    }

    public void LoadScore()
    {
        ScoreData data = SaveSystem.LoadScore();
        Score.text = data.Score;
        Score1.text = data.Score1;
        Score2.text = data.Score2;

        Name.text = data.Name;
        Name1.text = data.Name1;
        Name2.text = data.Name2;

    }
   
}
