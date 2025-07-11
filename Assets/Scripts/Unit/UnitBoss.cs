using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBoss : Unit
{
    [SerializeField] private float startReload = 2;
    private float reload;
    protected LookAtObject lookComp;
    protected override void Awake()
    {
        base.Awake();
        lookComp = GetComponent<LookAtObject>();
    }

    protected void Start()
    {
        reload = startReload;
        lives = 15 * GameController.instance.levelScene;
    }
    protected override void FixedUpdate()
    {
        if (target != null) lookComp.target = target;
        if (reload < 0)
        {
            reload = startReload;
            SpawnEnemyController.instance.SpawnEnemyInPos(WaveController.instance.levelUnit, this.transform);
        }
        else
        {
            reload -= Time.deltaTime;
        }
    }
}
