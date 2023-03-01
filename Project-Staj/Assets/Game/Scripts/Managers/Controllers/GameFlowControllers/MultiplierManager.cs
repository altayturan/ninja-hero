using System.Collections;
using UnityEngine;

public class MultiplierManager : MonoBehaviour
{
    [SerializeField] private Stat enemyHealthMultiplier;
    [SerializeField] private Stat spawnIntervalMultiplier;
    [SerializeField] private StateData stateData;
    [SerializeField] private float enemyHealthCooldown;
    [SerializeField] private float spawnIntervalCooldown;

    private void Start()
    {
        enemyHealthCooldown = 3f;
        spawnIntervalCooldown = 3f;
    }
    public void StartMultipliers()
    {
        StartCoroutine(MultiplyEnemyHealth());
        StartCoroutine(MultiplySpawnInterval());
    }

    public void StopMultipliers()
    {
        StopCoroutine(MultiplyEnemyHealth());
        StopCoroutine(MultiplySpawnInterval());
    }
    private IEnumerator MultiplyEnemyHealth()
    {
        while (true)
        {
           
            if (stateData.CurrentState == States.PLAY && enemyHealthCooldown > 0)
            {
                enemyHealthCooldown -= Time.deltaTime;
                yield return null;
                continue;
            }
            if (stateData.CurrentState == States.STOP)
            {
                StopCoroutine(MultiplyEnemyHealth());
                yield break;
            }
            enemyHealthMultiplier.Amount *= 1.1f;
            enemyHealthCooldown = 3f;
        }
    }

    private IEnumerator MultiplySpawnInterval()
    {
        while (true)
        {
            if(stateData.CurrentState == States.PLAY && spawnIntervalCooldown > 0)
            {
                spawnIntervalCooldown -= Time.deltaTime;
                yield return null;
                continue;
            }
            if (stateData.CurrentState == States.STOP)
            {
                StopCoroutine(MultiplySpawnInterval());
                yield break;
            }
            spawnIntervalMultiplier.Amount *= 0.9f;
            spawnIntervalCooldown = 3f;
        }
    }
}
