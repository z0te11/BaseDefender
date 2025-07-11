using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class RewardGiver : MonoBehaviour
{
    public static RewardGiver instance;

    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += AddRewardMoney;
    }

    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= AddRewardMoney;
    }

    private void AddRewardMoney(int id)
    {
        switch (id)
        {
            case 0:
            {
                SpaceMoneyController.AddSpaceMoney(DataBase.moneyForReward);
                break;
            }
            case 1:
            {
                SpaceMoneyController.AddSpaceMoney(RewardPanel.rewardSpaceMoney);
                break;
            }

        }
        SaveSystem.instance.SaveData();
    }

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
    }
}
