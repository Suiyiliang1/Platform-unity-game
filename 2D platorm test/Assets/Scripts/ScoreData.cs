using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ScoreData
{
    public string Name, Name1, Name2;
    public string Score, Score1, Score2;

    public ScoreData(ScoreboardScore ScoreboardData)
    {
        Name = ScoreboardData.Name.text;
        Name1 = ScoreboardData.Name1.text;
        Name2 = ScoreboardData.Name2.text;

        Score = ScoreboardData.Score.text;
        Score1 = ScoreboardData.Score1.text;
        Score2 = ScoreboardData.Score2.text;

    }
}
