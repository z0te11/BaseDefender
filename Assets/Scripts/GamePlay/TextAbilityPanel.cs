using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAbilityPanel : MonoBehaviour
{
    [SerializeField] private Text textDamageTurrent;
    [SerializeField] private Text textReloadTurrent;
    [SerializeField] private Text textTierTurrent;

    [SerializeField] private Text textDamageRocket;
    [SerializeField] private Text textReloadRocket;
    [SerializeField] private Text textTierRocket;

    [SerializeField] private Text textDamageBomb;
    [SerializeField] private Text textReloadBomb;
    [SerializeField] private Text textTierBomb;

    [SerializeField] private Text textRegenLive;
    [SerializeField] private Text textReloadLive;

    [SerializeField] private Text[] textShipSpawned;

    private void Start()
    {
        UpdateDamageTurrentText(0);
        UpdateReloadTurrentText(0);
        UpdateTierTurrentText(1);

        UpdateDamageRocketText(0);
        UpdateReloadRocketText(0);
        UpdateTierRocketText(1);

        UpdateDamageBombText(0);
        UpdateReloadBombText(0);
        UpdateTierBombText(1);

        UpdateDamageLiveText(0);
        UpdateReloadLiveText(0);
        UpdateSpawnPlayerShip(0);
    }
    private void OnEnable()
    {
        TurrentController.onUpgradeTurrentDamage += UpdateDamageTurrentText;
        TurrentController.onUpgradeTurrentReload += UpdateReloadTurrentText;
        TurrentController.onUpgradeTurrentTier += UpdateTierTurrentText;

        RocketController.onUpgradeRocketDamage += UpdateDamageRocketText;
        RocketController.onUpgradeRocketReload += UpdateReloadRocketText;
        RocketController.onUpgradeRocketTier += UpdateTierRocketText;

        BombController.onUpgradeBombDamage += UpdateDamageBombText;
        BombController.onUpgradeBombReload += UpdateReloadBombText;
        BombController.onUpgradeBombTier += UpdateTierBombText;

        LiveBuffController.onUpgradeLiveDamage += UpdateDamageLiveText;
        LiveBuffController.onUpgradeLiveReload += UpdateReloadLiveText;
        SpawnShipPanel.onSpawnPlayerShip += UpdateSpawnPlayerShip;
    }

    private void OnDisable()
    {
        TurrentController.onUpgradeTurrentDamage -= UpdateDamageTurrentText;
        TurrentController.onUpgradeTurrentReload -= UpdateReloadTurrentText;
        TurrentController.onUpgradeTurrentTier -= UpdateTierTurrentText;

        RocketController.onUpgradeRocketDamage -= UpdateDamageRocketText;
        RocketController.onUpgradeRocketReload -= UpdateReloadRocketText;
        RocketController.onUpgradeRocketTier -= UpdateTierRocketText;

        BombController.onUpgradeBombDamage -= UpdateDamageBombText;
        BombController.onUpgradeBombReload -= UpdateReloadBombText;
        BombController.onUpgradeBombTier -= UpdateTierBombText;

        LiveBuffController.onUpgradeLiveDamage -= UpdateDamageLiveText;
        LiveBuffController.onUpgradeLiveReload -= UpdateReloadLiveText;
        SpawnShipPanel.onSpawnPlayerShip -= UpdateSpawnPlayerShip;
    }
    private void UpdateDamageTurrentText(float newAmount)
    {
        textDamageTurrent.text = (DataBase.startDamageTurrent + newAmount).ToString();
    }

    private void UpdateReloadTurrentText(float newAmount)
    {
        textReloadTurrent.text = (DataBase.startReloadTurrent + newAmount).ToString();
    }

    private void UpdateTierTurrentText(int newAmount)
    {
        textTierTurrent.text = newAmount.ToString();
    }

    private void UpdateDamageRocketText(float newAmount)
    {
        textDamageRocket.text = (DataBase.startDamageRocket + newAmount).ToString();
    }

    private void UpdateReloadRocketText(float newAmount)
    {
        textReloadRocket.text = (DataBase.startReloadRocket + newAmount).ToString();
    }

    private void UpdateTierRocketText(int newAmount)
    {
        textTierRocket.text = newAmount.ToString();
    }

    private void UpdateDamageBombText(float newAmount)
    {
        textDamageBomb.text = (DataBase.startDamageBomb + newAmount).ToString();
    }

    private void UpdateReloadBombText(float newAmount)
    {
        textReloadBomb.text = (DataBase.startReloadBomb + newAmount).ToString();
    }

    private void UpdateTierBombText(int newAmount)
    {
        textTierBomb.text = newAmount.ToString();
    }

    private void UpdateDamageLiveText(float newAmount)
    {
        textRegenLive.text = (DataBase.startRegenLive + newAmount).ToString();
    }

    private void UpdateReloadLiveText(float newAmount)
    {
        textReloadLive.text = (DataBase.startReloadLive + newAmount).ToString();
    }

    private void UpdateSpawnPlayerShip(int newAmount)
    {
        for (int i = 0; i < textShipSpawned.Length; i++)
        {
            textShipSpawned[i].text = newAmount.ToString() + " / " + DataBase.maxCountPlayerShip;
        }    
    }
}
