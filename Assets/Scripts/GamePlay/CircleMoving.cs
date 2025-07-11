using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMoving : MonoBehaviour
{
    [SerializeField] public float radius = 2f, angularSpeed = 2f;
    [SerializeField] private float startChangePosInSec = 4f;
    public Transform center;
    float positionX, positionY, positionZ, angle = 0f;
    public bool isMove = false;
    private float changePosInSec;
    private bool dynamicZ;

    private void Start()
    {
        changePosInSec = startChangePosInSec;
        ChangePosForZ();
    }
    private void FixedUpdate()
    {
        if (isMove == true)
        {
            positionX = center.position.x + Mathf.Cos(angle) * radius;
            positionY = center.position.y + Mathf.Sin(angle) * radius;
            positionZ = center.position.z + Mathf.Sin(angle) * radius;
            transform.position = new Vector3(positionX, positionY, positionZ);
            angle = angle + Time.deltaTime * angularSpeed;

            if (angle >= 360f)
            {
                angle = 0f;
            }
        }
        if (changePosInSec < 0)
        {
            ChangePosForZ();
            changePosInSec = startChangePosInSec;
        }
        else
        {
            changePosInSec -= Time.deltaTime;
        }
    }

    private void ChangePosForZ()
    {
        dynamicZ = !dynamicZ;
    }
}
