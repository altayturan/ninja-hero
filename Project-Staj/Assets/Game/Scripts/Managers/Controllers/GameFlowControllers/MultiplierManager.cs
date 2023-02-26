using UnityEngine;

public class MultiplierManager : MonoBehaviour
{
    [SerializeField] private Stat enemyHealthMultiplier;
    [SerializeField] private Stat spawnIntervalMultiplier;


    private void Start()
    {
        InvokeRepeating("MultiplyEnemyHealth", 3f, 3f);
        InvokeRepeating("MultiplySpawnInterval", 3f, 3f);
    }
    public void MultiplyEnemyHealth()
    {
        enemyHealthMultiplier.Amount *= 1.1f;
    }

    public void MultiplySpawnInterval()
    {
        spawnIntervalMultiplier.Amount *= 1.1f;
    }
}
