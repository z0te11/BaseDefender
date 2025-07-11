using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    public static Action<int> onWaveStart;
    public float timeEveryWave = 2;
    public bool isWave = false;
    private int countWave = 1;
    public int levelUnit = 1;
    private float reloadWave;
    private bool isBoss1;
    private bool isBoss2;
    private SpawnEnemyController spawnCtrl;
    private int numberWave = 0;
    public static WaveController instance;

    private void Awake()
    {
        if (instance == null) instance = this;
        spawnCtrl = GetComponent<SpawnEnemyController>();
    }

    private void Start()
    {
        reloadWave = 0;
    }

    private void SetDifficulty()
    {
        switch (GameController.instance.levelScene)
        {
            case 1:
            {
                countWave = 1;
                levelUnit = 1;
                break;
            }
            case 2:
            {
                countWave = 1;
                levelUnit = 2;
                break;               
            }
            case 3:
            {
                countWave = 2;
                levelUnit = 2;
                break;               
            }
            case 4:
            {
                countWave = 2;
                levelUnit = 3;
                break;
            }
            case 5:
            {
                countWave = 3;
                levelUnit = 4;
                break;               
            }
            case 6:
            {
                countWave = 3;
                levelUnit = 4;
                break;               
            }
            case 7:
            {
                countWave = 4;
                levelUnit = 4;
                break;               
            }
            case 8:
            {
                countWave = 3;
                levelUnit = 5;
                break;               
            }
            case 9:
            {
                countWave = 3;
                levelUnit = 6;
                break;               
            }
            case 10:
            {
                countWave = 4;
                levelUnit = 6;
                break;               
            }
            case 11:
            {
                countWave = 4;
                levelUnit = 7;
                break;               
            }
            case 12:
            {
                countWave = 5;
                levelUnit = 7;
                break;               
            }
            case 13:
            {
                countWave = 4;
                levelUnit = 8;
                break;               
            }
            case 14:
            {
                countWave = 4;
                levelUnit = 9;
                break;               
            }
            case 15:
            {
                countWave = 5;
                levelUnit = 9;
                break;               
            }
            case 16:
            {
                countWave = 5;
                levelUnit = 10;
                break;               
            }
            case 17:
            {
                countWave = 6;
                levelUnit = 10;
                break;               
            }
            case 18:
            {
                countWave = 5;
                levelUnit = 11;
                break;               
            }
            case 19:
            {
                countWave = 6;
                levelUnit = 11;
                break;               
            }
            case 20:
            {
                countWave = 5;
                levelUnit = 12;
                break;               
            }
            default:
            {
                countWave = 6;
                levelUnit = 12;
                break;                  
            }
        }
    }

    private void FixedUpdate()
    {
        if (reloadWave < 0 && isWave)
        {
            NextWave();
            reloadWave = timeEveryWave;

        }
        else
        {
            reloadWave -= Time.deltaTime;
        }
    }

    public void HardToWave()
    {
        reloadWave = 0;
    }
    

    public void NextWave()
    {
        SetDifficulty();
        spawnCtrl.StartSpawns(countWave, levelUnit);
        CheckForBoss1();
        CheckForBoss2();
        numberWave++;
        GameController.instance.NextWaveGoing();
        onWaveStart?.Invoke(numberWave);
    }

    public void CheckForBoss1()
    {
        if (GameController.instance.levelScene % 6 == 0 && isBoss1)
        {
            spawnCtrl.SpawnBoss(1);
            isBoss1 = false;
        }
        if (GameController.instance.levelScene % 6 > 0) isBoss1 = true;
    }

    public void CheckForBoss2()
    {
        if (GameController.instance.levelScene % 9 == 0 && isBoss2)
        {
            spawnCtrl.SpawnBoss(2);
            isBoss2 = false;
        }
        if (GameController.instance.levelScene % 9 > 0) isBoss2 = true;
    }

    public void StartWave()
    {
        isWave = true;
    }
}
