using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyController : MonoBehaviour
{
    [SerializeField] private Transform[] spawnEnemyPoints;
    [SerializeField] private GameObject[] bossLevel1;

    [SerializeField] private GameObject[] enemyUnitLevel1;
    [SerializeField] private GameObject[] enemyUnitLevel2;
    [SerializeField] private GameObject[] enemyUnitLevel3;
    [SerializeField] private GameObject[] enemyUnitLevel4;
    [SerializeField] private GameObject[] enemyUnitLevel5;
    [SerializeField] private GameObject[] enemyUnitLevel6;
    [SerializeField] private GameObject[] enemyUnitLevel7;
    [SerializeField] private GameObject[] enemyUnitLevel8;
    [SerializeField] private GameObject[] enemyUnitLevel9;
    [SerializeField] private GameObject[] enemyUnitLevel10;
    [SerializeField] private GameObject[] enemyUnitLevel11;
    [SerializeField] private GameObject[] enemyUnitLevel12;
    [SerializeField] private GameObject[] enemyUnitLevel13;
    [SerializeField] private GameObject[] enemyUnitLevel14;
    [SerializeField] private GameObject[] enemyUnitLevel15;
    [SerializeField] private GameObject[] enemyUnitLevel16;
    [SerializeField] private GameObject[] enemyUnitLevel17;
    [SerializeField] private GameObject[] enemyUnitLevel18;
    [SerializeField] private GameObject[] enemyUnitLevel19;
    [SerializeField] private GameObject[] enemyUnitLevel20;

    public static SpawnEnemyController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void StartSpawns(int howMuch, int levelUnit)
    {
        if (howMuch > spawnEnemyPoints.Length) howMuch = spawnEnemyPoints.Length;
        ShufflePoints(spawnEnemyPoints);
        var whatUnit = levelUnit;
        for (int i = 0; i < howMuch; i++)
        {
            if (whatUnit < 1) whatUnit = 1;
            SpawnEnemyLevelInPoint(CheckWhatEnemy(whatUnit), spawnEnemyPoints[i]);
            //whatUnit -= 1; 
        }
    }

    public void SpawnBoss(int level)
    {
        switch (level)
        {
            case 1:
            {
                var enemyUnit = Instantiate(bossLevel1[0],new Vector3(150, 20, 0), Quaternion.identity);
                EnemyCollector.instance.AddEnemyInList(enemyUnit);    
                break;
            }
            case 2:
            {
                var enemyUnit = Instantiate(bossLevel1[1],new Vector3(0, 20, -150),  Quaternion.identity);
                EnemyCollector.instance.AddEnemyInList(enemyUnit);    
                break;
            }
            case 3:
            {
                for (int i = 0; i < 6; i++)
                {
                    var enemyUnit = Instantiate(bossLevel1[2],new Vector3(-150, 20, -50 + i*10),  Quaternion.identity);
                    EnemyCollector.instance.AddEnemyInList(enemyUnit);
                }
                break;
            }
        }
    }

    public void SpawnEnemyInPos(int level, Transform pos)
    {
        var enemyUnit = Instantiate(CheckWhatEnemy(level), pos.position, Quaternion.identity);
        EnemyCollector.instance.AddEnemyInList(enemyUnit);
    }

    private Transform[] ShufflePoints(Transform[] points)
    {
        Transform[] newPoints = new Transform[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            Transform currentValue = points[i];
            int randomIndex = Random.Range(i, points.Length);
            points[i] = points[randomIndex];
            points[randomIndex] = currentValue;
        }
        return newPoints;
    }

    private GameObject CheckWhatEnemy(int level)
    {
        switch (level)
        {
            case 1:
            {
                return enemyUnitLevel1[Random.Range(0, enemyUnitLevel1.Length)];
            }
            case 2:
            {
                return enemyUnitLevel2[Random.Range(0, enemyUnitLevel2.Length)];
            }
            case 3:
            {
                return enemyUnitLevel3[Random.Range(0, enemyUnitLevel3.Length)];
            }
            case 4:
            {
                return enemyUnitLevel4[Random.Range(0, enemyUnitLevel4.Length)];
            }
            case 5:
            {
                return enemyUnitLevel5[Random.Range(0, enemyUnitLevel5.Length)];
            }
            case 6:
            {
                return enemyUnitLevel6[Random.Range(0, enemyUnitLevel6.Length)];
            }
            case 7:
            {
                return enemyUnitLevel7[Random.Range(0, enemyUnitLevel7.Length)];
            }
            case 8:
            {
                return enemyUnitLevel8[Random.Range(0, enemyUnitLevel8.Length)];
            }
            case 9:
            {
                return enemyUnitLevel9[Random.Range(0, enemyUnitLevel9.Length)];
            }
            case 10:
            {
                return enemyUnitLevel10[Random.Range(0, enemyUnitLevel10.Length)];
            }
            case 11:
            {
                return enemyUnitLevel11[Random.Range(0, enemyUnitLevel11.Length)];
            }
            case 12:
            {
                return enemyUnitLevel12[Random.Range(0, enemyUnitLevel12.Length)];
            }
            case 13:
            {
                return enemyUnitLevel13[Random.Range(0, enemyUnitLevel13.Length)];
            }
            case 14:
            {
                return enemyUnitLevel14[Random.Range(0, enemyUnitLevel14.Length)];
            }
            case 15:
            {
                return enemyUnitLevel15[Random.Range(0, enemyUnitLevel15.Length)];
            }
            case 16:
            {
                return enemyUnitLevel16[Random.Range(0, enemyUnitLevel16.Length)];
            }
            case 17:
            {
                return enemyUnitLevel17[Random.Range(0, enemyUnitLevel17.Length)];
            }
            case 18:
            {
                return enemyUnitLevel18[Random.Range(0, enemyUnitLevel18.Length)];
            }
            case 19:
            {
                return enemyUnitLevel19[Random.Range(0, enemyUnitLevel19.Length)];
            }
            case 20:
            {
                return enemyUnitLevel20[Random.Range(0, enemyUnitLevel20.Length)];
            }
            default:
            {
                return enemyUnitLevel20[Random.Range(0, enemyUnitLevel20.Length)];
            }            
        }
    }
    private void SpawnEnemyLevelInPoint(GameObject enemyShip, Transform pointPos)
    {
        var enemyUnit = Instantiate(enemyShip, pointPos.position, Quaternion.identity);
        EnemyCollector.instance.AddEnemyInList(enemyUnit);
    }

    public void SpawnRowEnemyShip()
    {

    }
}
