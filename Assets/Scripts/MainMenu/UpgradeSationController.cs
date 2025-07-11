using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSationController : MonoBehaviour
{
    [SerializeField] private PlayerModule playerModule;
    [SerializeField] private GameObject buttonUpgrade;
    [SerializeField] private int[] moneyForUpgrade;

    public void Start()
    {
        SetStateButton();
    }

    private void OnEnable()
    {
        SpaceMoneyController.isSpaceMoneyChanged += SetStateButton;
    }

    private void OnDisable()
    {
        SpaceMoneyController.isSpaceMoneyChanged -= SetStateButton;
    }

    public void UpgradeStation()
    {
        if (DataBase.playerShipLevel < 6)
        {
            SpaceMoneyController.SpentSpaceMoney(moneyForUpgrade[DataBase.playerShipLevel]);
            DataBase.playerShipLevel += 1;
            playerModule.SetPlayerModules(DataBase.playerShipLevel);
            SetStateButton();
        }
    }

    public void SetStateButton()
    {
        if (DataBase.playerShipLevel >= 6)
        {
            buttonUpgrade.SetActive(false);
        }
        else
        {
            SetInteractableButton(CheckMoneyForUpgrade());
            SetTextPriceUpgrade();
        }
    }

    public void SetInteractableButton(bool isTrue)
    {
        var buttonComp = buttonUpgrade.GetComponent<Button>();
        buttonComp.interactable = isTrue;
    }

    public bool CheckMoneyForUpgrade()
    {
        return SpaceMoneyController.GetSpaceMoney() >= moneyForUpgrade[DataBase.playerShipLevel];
    }

    public void SetTextPriceUpgrade()
    {
        var textUpgrade = buttonUpgrade.GetComponentInChildren<Text>();
        textUpgrade.text = moneyForUpgrade[DataBase.playerShipLevel].ToString();
    }
}
