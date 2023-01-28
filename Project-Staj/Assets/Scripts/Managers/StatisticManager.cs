using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticManager : MonoBehaviour
{
    #region Singleton
    private StatisticManager statisticManager;
    private static StatisticManager _instance;

    public static StatisticManager Instance { get { return _instance; } }

    private void Awake()
    {

        if (_instance != null && _instance != this)  // SINGLETON
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        statisticManager = new StatisticManager();
    }
    #endregion

    #region Variables
    [Header("Player Stats")]
    public float playerHealth;
    public float playerSpeed;
    
    [Header("Shooting Stats")]
    public float fireInterval;
    public float bulletSpeed;
    public float bulletDamage;
    public int numberOfShots;
    public bool diagonalShot;
    
    [Header("Multipliers")]
    public float enemyHealthMultiplier;
    public float spawnIntervalMultiplier;
    #endregion

    #region Monobehaviour Functions
    private void Start()
    {
        InvokeRepeating("IncreaseEnemyHealthMultiplier",10f,15f);
        InvokeRepeating("IncreaseSpawnIntervalMultiplier",10f,15f);

    }
    #endregion

    #region Functions

    private void IncreaseEnemyHealthMultiplier()
    {
        enemyHealthMultiplier *= 1.1f;
    }
    private void IncreaseSpawnIntervalMultiplier()
    {
        spawnIntervalMultiplier *= 0.9f;
    }
    #endregion

}
