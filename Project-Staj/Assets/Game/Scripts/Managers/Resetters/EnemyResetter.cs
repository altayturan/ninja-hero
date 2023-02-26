using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyResetter : MonoBehaviour
{
    [SerializeField] private EnemyData enemyData;

    public void RestartEnemy()
    {
        enemyData.Health = enemyData.BaseHealth;
        enemyData.Speed = enemyData.BaseSpeed;
        enemyData.Damage = enemyData.BaseDamage;
        enemyData.Prize = enemyData.BasePrize;
    }

}
