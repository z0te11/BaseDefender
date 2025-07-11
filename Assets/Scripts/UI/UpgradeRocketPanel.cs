using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeRocketPanel : MonoBehaviour
{
    public static Action onUpgradeValueRocketButton;
    public static Action onUpgradeReloadRocketButton;
    public static Action onUpgradeTierRocketButton;


    protected int levelUpgradeRocketTier = 1;
    protected int levelUpgradeRocketValue = 1;
    protected int levelUpgradeRocketReload = 1;
    [SerializeField] protected UpgradeButton[] buttonsUpgrade;

    public void UpdgradeDamageButton()
    {
        if (levelUpgradeRocketValue < 20)
        {
            levelUpgradeRocketValue++;
            int cost = buttonsUpgrade[0].costUpgrade;
            buttonsUpgrade[0].SetCostUpgrade(buttonsUpgrade[0].startCostUpgrade * levelUpgradeRocketValue);
            MoneyController.instance.UseMoney(cost);
            onUpgradeValueRocketButton?.Invoke();
        }
    }

    public void UpdgradeReloadButton()
    {
        if (levelUpgradeRocketReload < 20)
        {
            levelUpgradeRocketReload++;
            int cost = buttonsUpgrade[1].costUpgrade;
            buttonsUpgrade[1].SetCostUpgrade(buttonsUpgrade[1].startCostUpgrade * levelUpgradeRocketReload);
            MoneyController.instance.UseMoney(cost);
            onUpgradeReloadRocketButton?.Invoke();
        }
    }

    public void UpdgradeTierButton()
    {
        if (levelUpgradeRocketTier < 3)
        {
            levelUpgradeRocketTier++;
            int cost = buttonsUpgrade[2].costUpgrade;
            buttonsUpgrade[2].SetCostUpgrade(buttonsUpgrade[2].startCostUpgrade * levelUpgradeRocketTier);
            MoneyController.instance.UseMoney(cost);
            onUpgradeTierRocketButton?.Invoke();
        }
    }
}
