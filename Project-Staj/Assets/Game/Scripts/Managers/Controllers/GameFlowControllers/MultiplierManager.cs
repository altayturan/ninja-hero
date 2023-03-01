using System.Collections;
using UnityEngine;

public class MultiplierManager : MonoBehaviour
{
    [SerializeField] private Stat enemyHealthMultiplier;
    [SerializeField] private Stat spawnIntervalMultiplier;
    [SerializeField] private StateData stateData;
    [SerializeField] private float enemyHealthCooldown;
    [SerializeField] private float spawnIntervalCooldown;

    public void StartMultipliers()
    {
        StartCoroutine(MultiplyEnemyHealth());
        StartCoroutine(MultiplySpawnInterval());
    }
    private IEnumerator MultiplyEnemyHealth()
    {
        enemyHealthCooldown = enemyHealthMultiplier.Amount;
        if (enemyHealthCooldown > 0 && stateData.CurrentState == States.PLAY)
        {
            enemyHealthCooldown -= Time.fixedDeltaTime;
            yield return null;
        }
        if (stateData.CurrentState == States.STOP)
        {
            StopCoroutine(MultiplyEnemyHealth());
        }
        enemyHealthMultiplier.Amount *= 1.1f;
    }

    private IEnumerator MultiplySpawnInterval()
    {
        spawnIntervalCooldown = spawnIntervalMultiplier.Amount;
        if (spawnIntervalCooldown > 0 && stateData.CurrentState == States.PLAY)
        {
            spawnIntervalCooldown -= Time.fixedDeltaTime;
            yield return null;
        }
        if (stateData.CurrentState == States.STOP)
        {
            StopCoroutine(MultiplyEnemyHealth());
        }
        spawnIntervalMultiplier.Amount *= 1.1f;
    }
}
