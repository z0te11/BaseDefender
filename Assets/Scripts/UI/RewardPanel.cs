using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RewardPanel : MonoBehaviour
{
    [SerializeField] private Text textRecord;
    [SerializeField] private Text textRewardMoney;

    public static int rewardSpaceMoney = 0;

    private void OnEnable()
    {
        CalculateNewReward();
        ShowRewardAndRecord();
    }
    private void CalculateNewReward()
    {
        int intData = (int)ProgressPhaseController.instance.progressPhase; 
        rewardSpaceMoney = intData/2;
    }

    private void ShowRewardAndRecord()
    {
        textRecord.text = ScoreController.instance.score.ToString();
        textRewardMoney.text = rewardSpaceMoney.ToString();
    }

    public void AddRewardPlayer()
    {
        SpaceMoneyController.AddSpaceMoney(rewardSpaceMoney);
    }

}
