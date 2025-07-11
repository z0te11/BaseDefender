using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMelee : Unit
{
    protected LookAtObject lookComp;
    protected override void Awake()
    {
        base.Awake();
        lookComp = GetComponent<LookAtObject>();
    }

    protected void Start()
    {
        lookComp.target = target;
    }
}
