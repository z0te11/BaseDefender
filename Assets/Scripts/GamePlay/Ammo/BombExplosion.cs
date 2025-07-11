using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    public float damage;
    [SerializeField] private GameObject explosionEffect;
    private List<Unit> unitList = new List<Unit>();

    protected virtual void OnTriggerEnter(Collider collider)
    {
        Unit enemyUnit = collider.GetComponent<Unit>();

        if (enemyUnit)
        {
            unitList.Add(enemyUnit);
        }
        DoDamageUnits();
    
    }

    private void DoDamageUnits()
    {
        for (int i = 0; i < unitList.Count; i++)
        {
            unitList[i].GetDamage(damage);
        }
        var bombEffect = Instantiate(explosionEffect, this.transform.position, transform.rotation);
        Destroy(gameObject);
    }


}
