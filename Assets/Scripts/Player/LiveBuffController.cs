using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class LiveBuffController : MonoBehaviour
{
    public static Action<float> onUpgradeLiveDamage;
    public static Action<float> onUpgradeLiveReload;
    public static Action<int> onUpgradeLiveTier;
    private int levelTierLive = 0;
    private float levelDamage = 0;
    private float levelSpeed = 0;

    private void OnEnable()
    {
        UpgradeLivePanel.onUpgradeValueLiveButton += UpgradeLiveDamage;
        UpgradeLivePanel.onUpgradeReloadLiveButton += UpgradeLiveSpeed;
        UpgradeLivePanel.onUpgradeTierLiveButton += UpgradeLiveTier;
    }

    private void OnDisable()
    {
        UpgradeLivePanel.onUpgradeValueLiveButton -= UpgradeLiveDamage;
        UpgradeLivePanel.onUpgradeReloadLiveButton -= UpgradeLiveSpeed;
        UpgradeLivePanel.onUpgradeTierLiveButton -= UpgradeLiveTier;
    }

    public void UpgradeLiveTier()
    {
        levelTierLive++;
        onUpgradeLiveTier?.Invoke(levelTierLive);
    }

    public void UpgradeLiveDamage()
    {
        levelDamage += DataBase.upgradeRegenLive;
        onUpgradeLiveDamage?.Invoke(levelDamage);
    }

    public void UpgradeLiveSpeed()
    {
        levelSpeed -= DataBase.upgradeReloadLive;
        onUpgradeLiveReload?.Invoke(levelSpeed);
    } 
}
