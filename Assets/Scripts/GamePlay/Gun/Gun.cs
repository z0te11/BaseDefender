using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    [SerializeField] public float startDamage;
    [SerializeField] public AudioSource audioShoot;
    protected float damage;
    [SerializeField] protected float startReload;
    protected float reload;
    [SerializeField] protected float distance;
    [SerializeField] protected GameObject ammoGun;
    protected float currentReload;

    protected virtual void Start()
    {
        reload = startReload;
        currentReload = reload;
        damage = startDamage;
    }


    public void Shoot()
    {
        var newAmmo = Instantiate(ammoGun, new Vector3(this.transform.position.x, this.transform.position.y - 0.5f, this.transform.position.z), transform.rotation);
        var mewAmmoComp = newAmmo.GetComponent<Ammo>();
        mewAmmoComp.damage = damage;
        if (audioShoot != null) audioShoot.Play();
    }

    public void UpgradeGunDamage(float level)
    {
        damage = startDamage + level;
    }

    public void UpgradeGunReload(float level)
    {
        reload = startReload + level;
    }
}
