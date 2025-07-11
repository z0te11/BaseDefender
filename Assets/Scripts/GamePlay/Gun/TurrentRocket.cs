using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentRocket : Turrent
{   
    protected override void SetSettingsFromBase()
    {
        startDamage = DataBase.startDamageRocket;
        startReload = DataBase.startReloadRocket;
        reload = startReload;        
    }
    protected override void OnEnable()
    {
        RocketController.onUpgradeRocketDamage += UpgradeGunDamage;
        RocketController.onUpgradeRocketReload += UpgradeGunReload;
        RocketController.onUpgradeRocketTier += UpgradeTierGun;
        EnemyCollector.onEnemyListChanged += FindEnemy;
    }

    protected override void OnDisable()
    {
        RocketController.onUpgradeRocketDamage -= UpgradeGunDamage;
        RocketController.onUpgradeRocketReload -= UpgradeGunReload;
        RocketController.onUpgradeRocketTier -= UpgradeTierGun;
        EnemyCollector.onEnemyListChanged -= FindEnemy;
    }
    protected override void FindEnemy()
    {
        enemy = EnemyCollector.instance.GetRandomEnemy();
    }
}
