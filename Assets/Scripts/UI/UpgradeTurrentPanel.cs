using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeTurrentPanel : MonoBehaviour
{
    public static Action onUpgradeValueButton;
    public static Action onUpgradeReloadButton;
    public static Action onUpgradeTierButton;


    protected int levelUpgradeTier = 1;
    protected int levelUpgradeValue = 1;
    protected int levelUpgradeReload = 1;
    [SerializeField] protected UpgradeButton[] buttonsUpgrade;

    

    public void UpdgradeDamageButton()
    {
        if (levelUpgradeValue < 20)
        {
            levelUpgradeValue++;
            int cost = buttonsUpgrade[0].costUpgrade;
            buttonsUpgrade[0].SetCostUpgrade(buttonsUpgrade[0].startCostUpgrade * levelUpgradeValue);
            MoneyController.instance.UseMoney(cost);
            onUpgradeValueButton?.Invoke();
        }
    }

    public void UpdgradeReloadButton()
    {
        if (levelUpgradeReload < 20)
        {
            levelUpgradeReload++;
            int cost = buttonsUpgrade[1].costUpgrade;
            buttonsUpgrade[1].SetCostUpgrade(buttonsUpgrade[1].startCostUpgrade * levelUpgradeReload);
            MoneyController.instance.UseMoney(cost);
            onUpgradeReloadButton?.Invoke();
        }
    }

    public void UpdgradeTierButton()
    {
        if (levelUpgradeTier < 3)
        {
            levelUpgradeTier++;
            int cost = buttonsUpgrade[2].costUpgrade;
            buttonsUpgrade[2].SetCostUpgrade(buttonsUpgrade[2].startCostUpgrade * levelUpgradeTier);
            MoneyController.instance.UseMoney(cost);
            onUpgradeTierButton?.Invoke();
        }
    }
    
}
