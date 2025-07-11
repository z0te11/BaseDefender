using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] public int startCostUpgrade = 10;
    public int costUpgrade;
    [SerializeField] private Text textCost;
    [SerializeField] private Image imageComp;
    private Button buttonComp;

    private void Awake()
    {
        buttonComp = GetComponent<Button>();
    }

    private void Start()
    {
        costUpgrade = startCostUpgrade;
    }

    private void OnEnable()
    {
        MoneyController.isMoneyChanged += RefreshStatButton;
        SetCostUpgrade(costUpgrade);
        RefreshStatButton();
    }

    private void OnDisable()
    {
        MoneyController.isMoneyChanged -= RefreshStatButton;
    }
    private void SetColorButton(bool isGreen)
    {
        if (isGreen) imageComp.color = Color.green;
        else imageComp.color = Color.red;
    }
    private void SetTextCost(int costUpgrade)
    {
        textCost.text = costUpgrade.ToString();
    }

    public void SetCostUpgrade(int newCost)
    {
        costUpgrade = newCost;
        SetTextCost(costUpgrade);
    }

    public void SetEnableButton(bool isEnable)
    {
        buttonComp.interactable = isEnable;
    }

    public void RefreshStatButton()
    {
        bool isEnable = (MoneyController.instance.GetMoney() >= costUpgrade);
        SetColorButton(isEnable);
        SetEnableButton(isEnable);
    }
}
