using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsPanel : MonoBehaviour
{
    [SerializeField] private Text textScore;
    [SerializeField] private Text textMoney;

    private void Start()
    {
        ShowText();
    }
    private void OnEnable()
    {
        ScoreController.isScoreChanged += ShowText;
        MoneyController.isMoneyChanged += ShowText;
    }

    private void OnDisable()
    {
        ScoreController.isScoreChanged -= ShowText;
        MoneyController.isMoneyChanged -= ShowText;     
    }
    private void ShowText()
    {
        textScore.text = ScoreController.instance.GetScore().ToString();
        textMoney.text = MoneyController.instance.GetMoney().ToString();
    }

}
