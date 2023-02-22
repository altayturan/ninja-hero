using UnityEngine;

public class MultiplierManager : MonoBehaviour
{
    public bool diagonalShot;

    [SerializeField] private Stat enemyHealthMultiplier;
    [SerializeField] private Stat spawnIntervalMultiplier;

    private void Start()
    {
        InvokeRepeating("IncreaseEnemyHealthMultiplier",10f,15f);
        InvokeRepeating("IncreaseSpawnIntervalMultiplier",10f,15f);
    }

    private void IncreaseEnemyHealthMultiplier()
    {
        enemyHealthMultiplier.Amount *= 1.1f;
    }
    private void IncreaseSpawnIntervalMultiplier()
    {
        spawnIntervalMultiplier.Amount *= 0.9f;
    }

}
