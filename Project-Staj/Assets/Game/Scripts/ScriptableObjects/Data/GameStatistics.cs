using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameStatistics", menuName = "Data/Create Game Statistics")]
public class GameStatistics : ScriptableObject
{
    [SerializeField] private int totalFiredBullet;
    [SerializeField] private int totalKilledEnemy;
    [SerializeField] private int totalSpentGold;
    [SerializeField] private int totalDie;
    [SerializeField] private float totalGameplayTime;

    public int TotalFiredBullet { get => totalFiredBullet; set => totalFiredBullet = value; }
    public int TotalKilledEnemy { get => totalKilledEnemy; set => totalKilledEnemy = value; }
    public int TotalSpentGold { get => totalSpentGold; set => totalSpentGold = value; }
    public int TotalDie { get => totalDie; set => totalDie = value; }
    public float TotalGameplayTime { get => totalGameplayTime; set => totalGameplayTime = value; }
}
