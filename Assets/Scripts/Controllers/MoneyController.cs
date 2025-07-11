using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    public int money = 150;
    public static MoneyController instance;
    public static Action isMoneyChanged;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddMoney(int howMuch)
    {
        money += howMuch;
        isMoneyChanged?.Invoke();
    }

    public void UseMoney(int howMuch)
    {
        money -= howMuch;
        isMoneyChanged?.Invoke();
    }

    public int GetMoney()
    {
        return money;
    }
}
