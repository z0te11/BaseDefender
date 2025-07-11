using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeLivePanel : MonoBehaviour
{
    public static Action onUpgradeValueLiveButton;
    public static Action onUpgradeReloadLiveButton;
    public static Action onUpgradeTierLiveButton;


    protected int levelUpgradeLiveTier = 1;
    protected int levelUpgradeLiveValue = 1;
    protected int levelUpgradeLiveReload = 1;
    [SerializeField] protected UpgradeButton[] buttonsUpgrade;

    public void UpdgradeDamageButton()
    {
        if (levelUpgradeLiveValue < 20)
        {
            levelUpgradeLiveValue++;
            int cost = buttonsUpgrade[0].costUpgrade;
            buttonsUpgrade[0].SetCostUpgrade(buttonsUpgrade[0].startCostUpgrade * levelUpgradeLiveValue);
            MoneyController.instance.UseMoney(cost);
            onUpgradeValueLiveButton?.Invoke();
        }
    }

    public void UpdgradeReloadButton()
    {
        if (levelUpgradeLiveReload < 20)
        {
            levelUpgradeLiveReload++;
            int cost = buttonsUpgrade[1].costUpgrade;
            buttonsUpgrade[1].SetCostUpgrade(buttonsUpgrade[1].startCostUpgrade * levelUpgradeLiveReload);
            MoneyController.instance.UseMoney(cost);
            onUpgradeReloadLiveButton?.Invoke();
        }
    }

    public void UpdgradeTierButton()
    {
        if (levelUpgradeLiveTier < 3)
        {
            levelUpgradeLiveTier++;
            int cost = buttonsUpgrade[2].costUpgrade;
            buttonsUpgrade[2].SetCostUpgrade(buttonsUpgrade[2].startCostUpgrade * levelUpgradeLiveTier);
            MoneyController.instance.UseMoney(cost);
            onUpgradeTierLiveButton?.Invoke();
        }
    }
}
