using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int score;

    public float GetCurrentScore()
    {
        return score;
    }
    public float SetCurrentScore()
    {
        return score = 0;
    }
    public void IncrementScore()
    {
        score++;
    }
    public void DecrementScore()
    {
        score -= 2  ;
    }
    public int Score
    {
        get { return score; }
    }

}
