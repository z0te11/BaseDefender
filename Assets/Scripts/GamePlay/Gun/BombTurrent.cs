using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTurrent : Turrent
{
    protected override void SetSettingsFromBase()
    {
        startDamage = DataBase.startDamageBomb;
        startReload = DataBase.startReloadBomb;
        reload = startReload;        
    }
    protected override void OnEnable()
    {
        BombController.onUpgradeBombDamage += UpgradeGunDamage;
        BombController.onUpgradeBombReload += UpgradeGunReload;
        BombController.onUpgradeBombTier += UpgradeTierGun;
        EnemyCollector.onEnemyListChanged += FindEnemy;
    }

    protected override void OnDisable()
    {
        BombController.onUpgradeBombDamage -= UpgradeGunDamage;
        BombController.onUpgradeBombReload -= UpgradeGunReload;
        BombController.onUpgradeBombTier -= UpgradeTierGun;
        EnemyCollector.onEnemyListChanged -= FindEnemy;
    }
    protected override void FindEnemy()
    {
        enemy = EnemyCollector.instance.GetRandomEnemy();
    }
}
