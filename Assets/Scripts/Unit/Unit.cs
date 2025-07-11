using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] public int levelUnit;
    [SerializeField] public float lives = 50f;
    [SerializeField] public float damage = 10f;
    [SerializeField] protected GameObject explosion;
    [SerializeField] protected float speed = 2f;
    [SerializeField] protected int scoreUnit = 10;
    [SerializeField] protected int moneyUnit = 20;
    [SerializeField] protected GameObject slowDebuff;
    protected Transform target;
    protected bool isMove = true;
    public bool isSlowed = false;
    
    protected virtual void Awake()
    {
        target = GetPlayerTransform();
    }
    protected Transform GetPlayerTransform()
    {
        return SpawnPlayerController.instance.player.transform;
    }

    protected virtual void FixedUpdate()
    {
        if (target != null && isMove) 
        {
            if (Vector3.Distance(transform.position, target.position) < 1000.0f) MoveToTarget();
            if (Vector3.Distance(transform.position, target.position) < 1.5f) AttackTarget();
            
        }
    }

    protected virtual void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    protected virtual void AttackTarget()
    {
        isMove = false;
        var playerLivesComp = target.GetComponent<PlayerLives>();
        playerLivesComp.GetDamage(damage);
        DieUnit();    
    }

    public void GetDamage(float damage)
    {
        lives -= damage;
        if (lives <= 0) DieUnit();
    }

    public void SlowUnit()
    {
        if(!isSlowed)
        {
            isSlowed = true;
            speed *= 0.7f;
            var expl = Instantiate(slowDebuff, this.transform.position, Quaternion.identity);
            expl.GetComponent<Transform>().SetParent(this.transform);
        }
    }

    public void DieUnit()
    {
        var expl = Instantiate(explosion, this.transform.position, Quaternion.identity);
        ScoreController.instance.AddScore(scoreUnit);
        MoneyController.instance.AddMoney(moneyUnit);
        EnemyCollector.instance.DeleteEnemyInList(this.gameObject);
        Destroy(gameObject);
    }
}
