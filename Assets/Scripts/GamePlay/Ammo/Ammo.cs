using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ammo : MonoBehaviour
{
    public bool isPlayer;
    public Transform target;
    public float damage;
    [SerializeField] protected float speed = 40;
    protected Rigidbody rb;

    protected void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected void FixedUpdate()
    {
        rb.velocity = -transform.forward * speed;
    }


}
