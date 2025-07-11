using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareLevelPanel : MonoBehaviour
{
    [SerializeField] private LevelButton levelButtonPhase1;
    [SerializeField] private LevelButton levelButtonPhase2;
    [SerializeField] private LevelButton levelButtonPhase3;

    public void OnEnable()
    {
        levelButtonPhase1.SetProgresBar(DataBase.progressPhase1);
        levelButtonPhase2.SetProgresBar(DataBase.progressPhase2);
        levelButtonPhase3.SetProgresBar(DataBase.progressPhase3);
        CheckProgressPhase();
    }

    private void CheckProgressPhase()
    {
        levelButtonPhase2.InteractableButton(false);
        levelButtonPhase3.InteractableButton(false);
        if (DataBase.progressPhase1 > 60)
        {
            levelButtonPhase2.InteractableButton(true);
        }
        if (DataBase.progressPhase2 > 60)
        {
            levelButtonPhase3.InteractableButton(true);
        }
    }
    public void SetLevelInformation(int level)
    {
        switch (level)
        {
            case 0:
            {
                DataBase.startLevelScene = 1;
                DataBase.numberPhase = 0;
                break;
            }
            case 1:
            {
                DataBase.startLevelScene = 3;
                DataBase.numberPhase = 1;
                break;
            }
            case 2:
            {
                DataBase.startLevelScene = 7;
                DataBase.numberPhase = 2;
                break;
            }
        }
    }
}
