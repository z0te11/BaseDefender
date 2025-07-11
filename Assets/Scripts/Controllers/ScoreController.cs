using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using YG;

public class ScoreController : MonoBehaviour
{
    public int score = 0;
    public static ScoreController instance;
    public static Action isScoreChanged;
    private const string YandexLeaderBoardName = "score";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddScore(int howMuch)
    {
        score += howMuch;
        isScoreChanged?.Invoke();
    }

    public void RefreshRecord()
    {
        if (score > DataBase.recordScore)
        {
            DataBase.recordScore = score;
            YandexGame.savesData.recordScore = DataBase.recordScore;
            YandexGame.NewLeaderboardScores(YandexLeaderBoardName, DataBase.recordScore);
        }
    }


    public int GetScore()
    {
        return score;
    }
}
