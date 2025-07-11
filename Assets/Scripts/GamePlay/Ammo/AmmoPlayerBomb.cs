using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPlayerBomb : AmmoPlayer
{
    [SerializeField] private GameObject bombExplosionObject;

    protected override void OnTriggerEnter(Collider collider)
    {
        Unit enemyUnit = collider.GetComponent<Unit>();

        if (enemyUnit)
        {
            var newAmmo = Instantiate(bombExplosionObject, this.transform.position, transform.rotation);
            var bombExplosionComp = newAmmo.GetComponent<BombExplosion>();
            bombExplosionComp.damage = damage;
            Destroy(gameObject);
        }
    
    }
}
