using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoEnemy : Ammo
{
    protected virtual void OnTriggerEnter(Collider collider)
    {
        PlayerLives player = collider.GetComponent<PlayerLives>();

        if (player)
        {
            player.GetDamage(damage);
            Destroy(gameObject);
        }
    
    }
}
