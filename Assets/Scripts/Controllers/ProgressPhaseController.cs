using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressPhaseController : MonoBehaviour
{
    public float progressPhase = 0;
    public static ProgressPhaseController instance;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    private void OnEnable()
    {
        WaveController.onWaveStart += CalculateProgress;
    }

    private void OnDisable()
    {
        WaveController.onWaveStart -= CalculateProgress;
    }
    private void CalculateProgress(int numberWave)
    {
        progressPhase = numberWave;
        switch (DataBase.numberPhase)
        {
            case 0:
            {
                if (progressPhase > DataBase.progressPhase1) DataBase.progressPhase1 = progressPhase;
                Debug.Log(DataBase.progressPhase1);
                break;
            }
            case 1:
            {
                if (progressPhase > DataBase.progressPhase2) DataBase.progressPhase2 = progressPhase;
                break;
            }
            case 2:
            {
                if (progressPhase > DataBase.progressPhase3) DataBase.progressPhase3 = progressPhase;
                break;
            }
        }
    }
}
