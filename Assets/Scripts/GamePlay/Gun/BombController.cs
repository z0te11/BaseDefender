using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public static Action<float> onUpgradeBombDamage;
    public static Action<float> onUpgradeBombReload;
    public static Action<int> onUpgradeBombTier;
    private int levelTierBomb = 0;
    private float levelDamage = 0;
    private float levelSpeed = 0;

    private void OnEnable()
    {
        UpgradeBombPanel.onUpgradeValueBombButton += UpgradeBombDamage;
        UpgradeBombPanel.onUpgradeReloadBombButton += UpgradeBombSpeed;
        UpgradeBombPanel.onUpgradeTierBombButton += UpgradeBombTier;
    }

    private void OnDisable()
    {
        UpgradeBombPanel.onUpgradeValueBombButton -= UpgradeBombDamage;
        UpgradeBombPanel.onUpgradeReloadBombButton -= UpgradeBombSpeed;
        UpgradeBombPanel.onUpgradeTierBombButton -= UpgradeBombTier;
    }

    public void UpgradeBombTier()
    {
        levelTierBomb++;
        onUpgradeBombTier?.Invoke(levelTierBomb);
    }

    public void UpgradeBombDamage()
    {
        levelDamage += DataBase.upgradeDamageBomb;
        onUpgradeBombDamage?.Invoke(levelDamage);
    }

    public void UpgradeBombSpeed()
    {
        levelSpeed -= DataBase.upgradeReloadBomb;
        onUpgradeBombReload?.Invoke(levelSpeed);
    } 
}
