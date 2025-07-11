using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemyCollector : MonoBehaviour
{
    public List<GameObject> enemysList;
    public static Action onEnemyListChanged;
    public static EnemyCollector instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddEnemyInList(GameObject enemy)
    {
        enemysList.Add(enemy);
        onEnemyListChanged?.Invoke();
    }

    public void DeleteEnemyInList(GameObject enemy)
    {
        enemysList.Remove(enemy);
        onEnemyListChanged?.Invoke();
    }

    public GameObject GetCloseEnemy(Transform currentPos)
    {
        if (enemysList.Count > 0)
        {
            float distance = 100f;
            var closeEnemy = enemysList[0];
            for (int i = 0; i < enemysList.Count; i++)
            {
                float dist = Vector3.Distance(enemysList[i].transform.position, transform.position);
                if (dist < distance)
                {
                    if (Vector3.Distance(enemysList[i].transform.position, currentPos.position) < Vector3.Distance(closeEnemy.transform.position, currentPos.position))
                    {
                        closeEnemy = enemysList[i];
                    }
                }
            }
            return closeEnemy;

        }else return null;
    }

    public GameObject GetRandomEnemy()
    {
        if (enemysList.Count > 0)
        {
            int i = UnityEngine.Random.Range(0, enemysList.Count);
            return enemysList[i];
        }
        else return null;
    }

}
