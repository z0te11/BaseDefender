using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModule : MonoBehaviour
{
    [SerializeField] private GameObject[] modulesShip;

    private void Start()
    {
        SetPlayerModules(DataBase.playerShipLevel);
    }

    public void SetPlayerModules(int level)
    {
        if (level >= modulesShip.Length) level = modulesShip.Length;

        for (int i = 0; i < level; i++)
        {
            modulesShip[i].SetActive(true);
        }
    }
}
