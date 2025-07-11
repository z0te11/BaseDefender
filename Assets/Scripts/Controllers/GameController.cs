using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static Action isGameStart;
    public static Action isGameLose;
    public static Action isGamePause;
    public static Action isGameUnpause;
    public static GameController instance;
    private SpawnPlayerController playerCtrl;
    private WaveController waveCtrl;
    public int defaultWaveToNextLevel = 5;
    private int waveToNextLevel;
    public int levelScene;
    public bool isPause = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        levelScene = DataBase.startLevelScene;
        playerCtrl = GetComponent<SpawnPlayerController>();
        waveCtrl = GetComponent<WaveController>();
    }
    private void Start()
    {
        waveToNextLevel = defaultWaveToNextLevel;
    }

    private void FixedUpdate()
    {
        if (waveToNextLevel <= 0)
        {
            NextLevelScene();
            waveToNextLevel = defaultWaveToNextLevel + levelScene/2;
        }
    }

    public void StartGame()
    {
        playerCtrl.SpawnPlayer();
        waveCtrl.StartWave();
        UnpauseGame();
        isGameStart?.Invoke();
    }

    public void NextWaveGoing()
    {
        waveToNextLevel -= 1;
    }

    public void NextLevelScene()
    {
        levelScene += 1;
    }

    public void StopGame()
    {
        Time.timeScale = 0f;
    }

    public void LoseGame()
    {
        StopGame();
        ScoreController.instance.RefreshRecord();
        SaveSystem.instance.SaveData();
        isGameLose?.Invoke();
    }

    public void PauseGame()
    {
        isGamePause?.Invoke();
        isPause = true;
        Time.timeScale = 0f; 
    }

    public void UnpauseGame()
    {
        isGameUnpause?.Invoke();
        isPause = false;
        Time.timeScale = 1f;
    }
}
