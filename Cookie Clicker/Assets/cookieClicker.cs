using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookieClicker : MonoBehaviour
{

    int Score = 0;
    public Text scoreText;
    int inc = 1;
    public Text incText;

    public void ScoreUp()
    {
        Score += 1;
        scoreText.text = Score + " ";

    }

    public void Shop()
    {

        if (Score >= 5)
        {
            Score -= 5;
            inc += 1;
            scoreText.text = Score + " ";
            incText.text = inc + " ";
        }

    }
}
