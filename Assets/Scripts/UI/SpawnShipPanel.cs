using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SpawnShipPanel : MonoBehaviour
{
    public static Action<int> onSpawnPlayerShip;
    private int countShip = 0;
    [SerializeField] protected UpgradeButton[] buttonsSpawn;

    public void SpawnTurrentShip()
    {
        if (countShip < DataBase.maxCountPlayerShip)
        {
            countShip++;
            int cost = buttonsSpawn[0].costUpgrade;
            buttonsSpawn[0].SetCostUpgrade(buttonsSpawn[0].startCostUpgrade * countShip);
            MoneyController.instance.UseMoney(cost);
            SpawnPlayerController.instance.SpawnTurrentPlayerShip();
            onSpawnPlayerShip?.Invoke(countShip);
        }
    }

    public void SpawnRocketShip()
    {
        if (countShip < DataBase.maxCountPlayerShip)
        {
            countShip++;
            int cost = buttonsSpawn[1].costUpgrade;
            buttonsSpawn[1].SetCostUpgrade(buttonsSpawn[1].startCostUpgrade * countShip);
            MoneyController.instance.UseMoney(cost);
            SpawnPlayerController.instance.SpawnRocketPlayerShip();
            onSpawnPlayerShip?.Invoke(countShip);
        }
    }

    public void SpawnBombShip()
    {
        if (countShip < DataBase.maxCountPlayerShip)
        {
            countShip++;
            int cost = buttonsSpawn[2].costUpgrade;
            buttonsSpawn[2].SetCostUpgrade(buttonsSpawn[2].startCostUpgrade * countShip);
            MoneyController.instance.UseMoney(cost);
            SpawnPlayerController.instance.SpawnBombPlayerShip();
            onSpawnPlayerShip?.Invoke(countShip);
        }
    }
}
