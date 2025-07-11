using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public static Action<float> isLivesChanged;
    [SerializeField] private float lives = 100f;
    private float reloadRegen;
    private float currentReloadRegen;
    private float regenLive;
    private float startLives;

    private void OnEnable()
    {
        LiveBuffController.onUpgradeLiveDamage += UpgradeRegenLive;
        LiveBuffController.onUpgradeLiveReload += UpgradeReloadRegenLive;
    }

    private void OnDisable()
    {
        LiveBuffController.onUpgradeLiveDamage -= UpgradeRegenLive;
        LiveBuffController.onUpgradeLiveReload -= UpgradeReloadRegenLive;
    }
    private void Start()
    {
        regenLive = DataBase.startRegenLive;
        startLives = lives;
        reloadRegen = DataBase.startReloadLive;
        currentReloadRegen = reloadRegen;
    }

    private void FixedUpdate()
    {
        if (currentReloadRegen < 0)
        {
            RegenLive();
            currentReloadRegen = reloadRegen;
        }
        else
        {
            currentReloadRegen -= Time.deltaTime;
        }
    }

    public void GetDamage(float damage)
    {
        lives -= damage;
        isLivesChanged?.Invoke(lives);
        if (lives <= 0) Die();
    }

    public void HealLives(float heal)
    {
        if ((lives + heal) > startLives) lives = startLives;
        else lives += heal;
        isLivesChanged?.Invoke(lives);
    }

    private void Die()
    {
        GameController.instance.LoseGame();
    }

    private void UpgradeReloadRegenLive(float newReload)
    {
        reloadRegen = DataBase.startReloadLive + newReload;
    }

    private void UpgradeRegenLive(float newRegen)
    {
        regenLive = DataBase.startRegenLive + newRegen;
    }

    private void RegenLive()
    {
        HealLives(regenLive);
    }
}
