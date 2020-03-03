using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    void Start()
    {
        score = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = (int)score + "";
        score += 10 * (Time.deltaTime);
    }
}
