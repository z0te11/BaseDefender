using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    [SerializeField] protected float speed = 1f;
	public Transform target;

    protected virtual void FixedUpdate()
    {
        if (target != null)
		{
			Vector3 targetDirection = target.position - transform.position;
			Vector3 newDirection = Vector3.RotateTowards(-transform.forward, targetDirection, speed * Time.deltaTime, 0.0f);
			transform.rotation = Quaternion.LookRotation(-newDirection);
		}

    }

	
}
