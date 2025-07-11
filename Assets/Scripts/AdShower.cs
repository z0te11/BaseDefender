using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class AdShower : MonoBehaviour
{
    public float timerAd = 200;
    private float currentTimer;
    public GameController gameCtrl;

    private void Start()
    {
        currentTimer = timerAd;
    }

    private void Update()
    {
        if (currentTimer > 0)
        {
            currentTimer -= Time.deltaTime;
        }
        else if (currentTimer < 0 && !gameCtrl.isPause)
        {
            currentTimer = timerAd;
            gameCtrl.PauseGame();
            YandexGame.FullscreenShow();
        }
    }
}
