using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitShip : Unit
{
    protected LookAtObject lookComp;
    protected ShipGun shipGun;
    protected override void Awake()
    {
        base.Awake();
        lookComp = GetComponent<LookAtObject>();
        shipGun = GetComponent<ShipGun>();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        if (Vector3.Distance(transform.position, target.position) < 30.0f && isMove)
        {
            isMove = false;
            shipGun.isAttack = true;
        } 
    }

    protected void Start()
    {
        lookComp.target = target;
    }
}
