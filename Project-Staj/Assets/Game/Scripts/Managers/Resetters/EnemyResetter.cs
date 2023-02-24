using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyResetter : MonoBehaviour
{
    [SerializeField] private EnemyData enemyData;

    private float defaultHealth;
    private float defaultDamage;
    private float defaultSpeed;
    private int defaultPrize;
    void Awake()
    {
        defaultDamage = enemyData.Damage;
        defaultPrize = enemyData.Prize;
        defaultSpeed = enemyData.Speed;
        defaultHealth = enemyData.Health;
    }

    public void RestartEnemy()
    {
        enemyData.Health = defaultHealth;
        enemyData.Speed = defaultSpeed;
        enemyData.Damage = defaultDamage;
        enemyData.Prize = defaultPrize;
    }

}
