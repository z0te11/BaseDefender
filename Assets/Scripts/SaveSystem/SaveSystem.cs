using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem instance;

    private void Awake()
    {
        if (instance == null)
        { 
	        instance = this; 
	    } else if (instance != this)
        { 
	        Destroy(gameObject);
	    }
        DontDestroyOnLoad(gameObject);
        LoadData();
    }

    private void Start()
    {
        //YandexGame.GameplayStart();
    }

    private void OnEnable()
    {
        YandexGame.GetDataEvent += LoadData;
    }

    private void OnDisable()
    {
        YandexGame.GetDataEvent -= LoadData;
    }

    public void SaveData()
    {
        YandexGame.savesData.recordScore = DataBase.recordScore;

        YandexGame.savesData.playerShipLevel = DataBase.playerShipLevel;

        YandexGame.savesData.progressPhase1 = DataBase.progressPhase1;
        YandexGame.savesData.progressPhase2 =  DataBase.progressPhase2;
        YandexGame.savesData.progressPhase3 = DataBase.progressPhase3;

        YandexGame.savesData.maxCountPlayerShip = DataBase.maxCountPlayerShip;

        YandexGame.savesData.spaceMoney = SpaceMoneyController.spaceMoney;
        YandexGame.SaveProgress();
    }

    public void LoadData()
    {
        DataBase.recordScore = YandexGame.savesData.recordScore;

        DataBase.playerShipLevel = YandexGame.savesData.playerShipLevel;

        DataBase.progressPhase1 = YandexGame.savesData.progressPhase1;
        DataBase.progressPhase2 = YandexGame.savesData.progressPhase2;
        DataBase.progressPhase3 = YandexGame.savesData.progressPhase3;

        DataBase.maxCountPlayerShip = YandexGame.savesData.maxCountPlayerShip;

        SpaceMoneyController.spaceMoney = YandexGame.savesData.spaceMoney;
    }
}
