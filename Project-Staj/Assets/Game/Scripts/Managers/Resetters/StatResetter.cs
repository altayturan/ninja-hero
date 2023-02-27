using UnityEngine;

public class StatResetter : MonoBehaviour
{
    [SerializeField] private Stat spawnInterval;
    [SerializeField] private Stat enemyHealthMultiplier;
    [SerializeField] private Stat spawnIntervalMultiplier;

    public void RestartStats()
    {
        spawnInterval.Amount = spawnInterval.BaseAmount;
        enemyHealthMultiplier.Amount = enemyHealthMultiplier.BaseAmount;
        spawnIntervalMultiplier.Amount = spawnIntervalMultiplier.BaseAmount;
    }

}
