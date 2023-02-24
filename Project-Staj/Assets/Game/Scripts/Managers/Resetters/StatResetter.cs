using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatResetter : MonoBehaviour
{
    [SerializeField] private Stat spawnInterval;
    [SerializeField] private Stat enemyHealthMultiplier;
    [SerializeField] private Stat spawnIntervalMultiplier;

    private float defaultSpawnInterval;
    private float defaultEnemyHealthMultiplier;
    private float defaultSpawnIntervalMultiplier;
    void Start()
    {
        defaultSpawnInterval = spawnInterval.Amount;
        defaultEnemyHealthMultiplier = enemyHealthMultiplier.Amount;
        defaultSpawnIntervalMultiplier = spawnIntervalMultiplier.Amount;
    }

    public void RestartStats()
    {
        spawnInterval.Amount = defaultSpawnInterval;
        enemyHealthMultiplier.Amount = defaultEnemyHealthMultiplier;
        spawnIntervalMultiplier.Amount = defaultSpawnIntervalMultiplier;
    }

}
