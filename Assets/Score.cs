using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Change to how many digits you want
    public int scoreLength = 8;

    // this is the score
    public int score = 25;

    // Update is called once per frame
    void Update()
    {
        score++;

        UpdateScore();
    }

    public void UpdateScore()
    {
        // score as a string
        string scoreString = score.ToString();

        // get number of 0s needed
        int numZeros = scoreLength - scoreString.Length;

        string newScore = "";
        for (int i = 0; i < numZeros; i++)
        {
            newScore += "0";
        }

        newScore += scoreString;

        this.GetComponent<Text>().text = newScore;
    }
}
