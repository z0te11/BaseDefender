using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SpaceMoneyController
{
    public static int spaceMoney = 0;
    public static Action isSpaceMoneyChanged;

    public static void AddSpaceMoney(int newSpaceMoney)
    {
        spaceMoney += newSpaceMoney;
        isSpaceMoneyChanged?.Invoke();
    }

    public static int GetSpaceMoney()
    {
        return spaceMoney;
    }

    public static void SpentSpaceMoney(int newSpaceMoney)
    {
        spaceMoney -= newSpaceMoney;
        isSpaceMoneyChanged?.Invoke();
    }
}
