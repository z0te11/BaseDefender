using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPlayer : Ammo
{
    [SerializeField] private bool canSlow = false;
    protected virtual void OnTriggerEnter(Collider collider)
    {
        Unit enemyUnit = collider.GetComponent<Unit>();

        if (enemyUnit)
        {
            enemyUnit.GetDamage(damage);
            if (canSlow) enemyUnit.SlowUnit();
            Destroy(gameObject);
        }
    
    }
}
