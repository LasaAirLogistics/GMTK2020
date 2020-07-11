using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public static string scoreValue;
    public Text score;
    public string scoreText;
    public string outOf;
    public int updateScore;

    // Start is called before the first frame update
    void Start()
    {
      //Convert.ToInt32
        score = GetComponent<Text>();
        scoreText = score.text;
        outOf= scoreText.Substring(scoreText.Length - 1);
    }

    // Update is called once per frame
    void Update()
    {
        updateScore = updateScore + 1;
        score.text = "Kills: " + updateScore + "/" + outOf;
    }
}
