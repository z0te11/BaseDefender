using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSpaceMoneyText : MonoBehaviour
{
    [SerializeField] private Text textMoney;

    private void Update()
    {
        textMoney.text = SpaceMoneyController.spaceMoney.ToString();
    }
}
