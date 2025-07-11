using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    [SerializeField] private float sec = 2;
    public bool isStartDestroy = true;

    private void Update()
    {
        if (isStartDestroy)
        {
            sec -= Time.deltaTime;
        }
        if (sec <= 0) DestroyObject();
    }

    public void StartDestroyObject()
    {
        isStartDestroy = true;
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
