using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGun : Gun
{
    public bool isAttack = false;
    protected Transform target;
    protected void FindPlayer()
    {
        target =  SpawnPlayerController.instance.player.transform;
    }

    protected void FixedUpdate()
    {
        if (target == null) FindPlayer();
        else if (target != null && currentReload <= 0 && isAttack) 
        {
            currentReload = reload;
            Shoot();
        }
        currentReload -= Time.deltaTime;
    }
}
