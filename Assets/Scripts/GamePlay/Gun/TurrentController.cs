using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TurrentController : MonoBehaviour
{
    public static Action<float> onUpgradeTurrentDamage;
    public static Action<float> onUpgradeTurrentReload;
    public static Action<int> onUpgradeTurrentTier;
    private int levelTierTurrent = 0;
    private float levelDamage = 0;
    private float levelSpeed = 0;

    private void OnEnable()
    {
        UpgradeTurrentPanel.onUpgradeValueButton += UpgradeTurrentDamage;
        UpgradeTurrentPanel.onUpgradeReloadButton += UpgradeTurrentSpeed;
        UpgradeTurrentPanel.onUpgradeTierButton += UpgradeTurrentTier;
    }

    private void OnDisable()
    {
        UpgradeTurrentPanel.onUpgradeValueButton -= UpgradeTurrentDamage;
        UpgradeTurrentPanel.onUpgradeReloadButton -= UpgradeTurrentSpeed;
        UpgradeTurrentPanel.onUpgradeTierButton -= UpgradeTurrentTier;
    }

    public void UpgradeTurrentTier()
    {
        levelTierTurrent++;
        onUpgradeTurrentTier?.Invoke(levelTierTurrent);
    }

    public void UpgradeTurrentDamage()
    {
        levelDamage += DataBase.upgradeDamageTurrent;
        onUpgradeTurrentDamage?.Invoke(levelDamage);
    }

    public void UpgradeTurrentSpeed()
    {
        levelSpeed -= DataBase.upgradeReloadTurrent;
        onUpgradeTurrentReload?.Invoke(levelSpeed);
    } 
}
