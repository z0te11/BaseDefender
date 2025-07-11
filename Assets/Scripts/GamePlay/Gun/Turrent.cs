using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrent : Gun
{
    public GameObject enemy;
    [SerializeField] private GameObject ammoPlayerTier2;
    protected LookAtObject lookComp;

    protected virtual void Awake()
    {
        lookComp = GetComponent<LookAtObject>();
    }

    protected override void Start()
    {
        base.Start();
        SetSettingsFromBase();
    }

    protected virtual void SetSettingsFromBase()
    {
        startDamage = DataBase.startDamageTurrent;
        startReload = DataBase.startReloadTurrent;
        reload = startReload;
    }

    protected virtual void OnEnable()
    {
        TurrentController.onUpgradeTurrentDamage += UpgradeGunDamage;
        TurrentController.onUpgradeTurrentReload += UpgradeGunReload;
        TurrentController.onUpgradeTurrentTier += UpgradeTierGun;
        EnemyCollector.onEnemyListChanged += FindEnemy;
    }

    protected virtual void OnDisable()
    {
        TurrentController.onUpgradeTurrentDamage -= UpgradeGunDamage;
        TurrentController.onUpgradeTurrentReload -= UpgradeGunReload;
        TurrentController.onUpgradeTurrentTier -= UpgradeTierGun;
        EnemyCollector.onEnemyListChanged -= FindEnemy;
    }

    protected virtual void FixedUpdate()
    {
        if (enemy != null) lookComp.target = enemy.transform;
        if (currentReload <= 0 && enemy != null) StartShoot();
        currentReload -= Time.deltaTime;
    }

    protected virtual void StartShoot()
    {
        currentReload = reload + Random.Range(-0.1f, 0.1f);
        Shoot();
    }

    protected virtual void FindEnemy()
    {
        enemy = EnemyCollector.instance.GetCloseEnemy(this.transform);
    }

    public virtual void UpgradeTierGun(int level)
    {
        switch (level)
        {
            case 1:
            {
                ammoGun = ammoPlayerTier2;
                break;
            }
            default:
            {
                ammoGun = ammoPlayerTier2;
                break;               
            }
        }
    }



}
