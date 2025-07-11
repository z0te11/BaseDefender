using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardButton : MonoBehaviour
{
    [SerializeField] private Text textReward;

    public int id;
    private void Start()
    {
        switch (id)
        {
            case 0:
            {
                textReward.text = DataBase.moneyForReward.ToString();
                break;
            }
            case 1:
            {
                textReward.text = RewardPanel.rewardSpaceMoney.ToString();
                break;
            }
        }
        
    }
}
