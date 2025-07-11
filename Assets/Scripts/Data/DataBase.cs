using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase
{
    public static int recordScore = 0; 
    public static int playerShipLevel = 1; 
    public static int startLevelScene = 1;
    public static int startTimeWavetLevel = 0;
    public static int numberPhase = 0;

    public static float progressPhase1 = 0;
    public static float progressPhase2 = 0;
    public static float progressPhase3 = 0;

    public static float startDamageTurrent = 6.5f;
    public static float startReloadTurrent = 4f;
    public static float upgradeDamageTurrent = 1.2f;
    public static float upgradeReloadTurrent = 0.15f;

    public static float startDamageRocket = 30.0f;
    public static float startReloadRocket = 6f;
    public static float upgradeDamageRocket = 2.5f;
    public static float upgradeReloadRocket = 0.2f;

    public static float startDamageBomb = 70f;
    public static float startReloadBomb = 8f;
    public static float upgradeDamageBomb = 5f;
    public static float upgradeReloadBomb = 0.25f;

    public static float startRegenLive = 0.5f;
    public static float startReloadLive = 5f;
    public static float upgradeRegenLive = 1.5f;
    public static float upgradeReloadLive = 0.1f;

    public static int maxCountPlayerShip = 3;

    public static int moneyForReward = 10;
}
