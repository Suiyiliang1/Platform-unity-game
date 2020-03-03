using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

namespace Yiliang.scoreboard
{
    public class socreboardEntryUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI EntryRankText = null;
        [SerializeField] private TextMeshProUGUI EntryNameText = null;
        [SerializeField] private TextMeshProUGUI EntryScoreText = null;

        public void Initialize(scoreboardEntrydata scoreboardEntrydata)
        {
            EntryRankText.text = scoreboardEntrydata.rank.ToString();
            EntryNameText.text = scoreboardEntrydata.name;
            EntryScoreText.text = scoreboardEntrydata.score.ToString();
        }

    }
}
