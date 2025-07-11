using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public static Action<float> onUpgradeRocketDamage;
    public static Action<float> onUpgradeRocketReload;
    public static Action<int> onUpgradeRocketTier;
    private int levelTierRocket = 0;
    private float levelDamage = 0;
    private float levelSpeed = 0;

    private void OnEnable()
    {
        UpgradeRocketPanel.onUpgradeValueRocketButton += UpgradeRocketDamage;
        UpgradeRocketPanel.onUpgradeReloadRocketButton += UpgradeRocketSpeed;
        UpgradeRocketPanel.onUpgradeTierRocketButton += UpgradeRocketTier;
    }

    private void OnDisable()
    {
        UpgradeRocketPanel.onUpgradeValueRocketButton -= UpgradeRocketDamage;
        UpgradeRocketPanel.onUpgradeReloadRocketButton -= UpgradeRocketSpeed;
        UpgradeRocketPanel.onUpgradeTierRocketButton -= UpgradeRocketTier;
    }

    public void UpgradeRocketTier()
    {
        levelTierRocket++;
        onUpgradeRocketTier?.Invoke(levelTierRocket);
    }

    public void UpgradeRocketDamage()
    {
        levelDamage += DataBase.upgradeDamageRocket;
        onUpgradeRocketDamage?.Invoke(levelDamage);
    }

    public void UpgradeRocketSpeed()
    {
        levelSpeed -= DataBase.upgradeReloadRocket;
        onUpgradeRocketReload?.Invoke(levelSpeed);
    } 
}
