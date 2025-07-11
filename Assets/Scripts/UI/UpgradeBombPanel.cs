using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeBombPanel : MonoBehaviour
{
    public static Action onUpgradeValueBombButton;
    public static Action onUpgradeReloadBombButton;
    public static Action onUpgradeTierBombButton;


    protected int levelUpgradeBombTier = 1;
    protected int levelUpgradeBombValue = 1;
    protected int levelUpgradeBombReload = 1;
    [SerializeField] protected UpgradeButton[] buttonsUpgrade;

    public void UpdgradeDamageButton()
    {
        if (levelUpgradeBombValue < 20)
        {
            levelUpgradeBombValue++;
            int cost = buttonsUpgrade[0].costUpgrade;
            buttonsUpgrade[0].SetCostUpgrade(buttonsUpgrade[0].startCostUpgrade * levelUpgradeBombValue);
            MoneyController.instance.UseMoney(cost);
            onUpgradeValueBombButton?.Invoke();
        }
    }

    public void UpdgradeReloadButton()
    {
        if (levelUpgradeBombReload < 20)
        {
            levelUpgradeBombReload++;
            int cost = buttonsUpgrade[1].costUpgrade;
            buttonsUpgrade[1].SetCostUpgrade(buttonsUpgrade[1].startCostUpgrade * levelUpgradeBombReload);
            MoneyController.instance.UseMoney(cost);
            onUpgradeReloadBombButton?.Invoke();
        }
    }

    public void UpdgradeTierButton()
    {
        if (levelUpgradeBombTier < 3)
        {
            levelUpgradeBombTier++;
            int cost = buttonsUpgrade[2].costUpgrade;
            buttonsUpgrade[2].SetCostUpgrade(buttonsUpgrade[2].startCostUpgrade * levelUpgradeBombTier);
            MoneyController.instance.UseMoney(cost);
            onUpgradeTierBombButton?.Invoke();
        }
    }
}
