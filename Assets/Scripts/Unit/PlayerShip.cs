using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    
    [SerializeField] private CircleMoving circleMove;
    [SerializeField] private float speed;
    private Transform target;
    private GameObject enemy;
    private LookAtObject lookComp;
	private bool isMove = true;
    
    private void Awake()
    {
        lookComp = GetComponent<LookAtObject>();
    }
    private void Start()
    {
        target = SpawnPlayerController.instance.player.transform;
    }

    protected virtual void OnEnable()
    {
        EnemyCollector.onEnemyListChanged += FindEnemy;
    }

    protected virtual void OnDisable()
    {
        EnemyCollector.onEnemyListChanged -= FindEnemy;
    }

    protected virtual void FindEnemy()
    {
        enemy = EnemyCollector.instance.GetCloseEnemy(this.transform);
    }


    private void FixedUpdate()
    {
        if (isMove && target != null) MoveToTarget();
        if (enemy != null) lookComp.target = enemy.transform;
        if (Vector3.Distance(transform.position, target.position) < 20.0f && isMove)
        {
            isMove = false;
            circleMove.center = target;
            circleMove.isMove = true;
        } 
    }

    protected virtual void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

}
