using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanel : MonoBehaviour
{
    [SerializeField] private GameObject[] categoryButton;
    [SerializeField] private GameObject[] blockImage;

    private void Start()
    {
        SetUpgradeButtons();
        SetCategory(0);
    }

    public void SetCategory(int categ)
    {
        for (int i = 0; i < categoryButton.Length; i++)
        {
            categoryButton[i].SetActive(false);
            if (i == categ) categoryButton[i].SetActive(true);
        }
    }

    private void SetUpgradeButtons()
    {
        switch (DataBase.playerShipLevel)
        {
            case 1:
            {
                blockImage[0].SetActive(true);
                blockImage[1].SetActive(true);
                blockImage[2].SetActive(true);
                break;
            }
            case 2:
            {
                blockImage[0].SetActive(false);
                blockImage[1].SetActive(true);
                blockImage[2].SetActive(true);
                break;
            }
            case 3:
            {
                blockImage[0].SetActive(false);
                blockImage[1].SetActive(false);
                blockImage[2].SetActive(true);
                break;
            }
            default:
            {
                blockImage[0].SetActive(false);
                blockImage[1].SetActive(false);
                blockImage[2].SetActive(false);
                break;
            }
        }
    }
}
