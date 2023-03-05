using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private Transform[] spawners;
    [SerializeField] private List<Pooler<EnemyController>> enemyPools;
    [SerializeField] private Stat spawnInterval;
    [SerializeField] private Stat spawnIntervalMultiplier;
    [SerializeField] private StateData stateData;
    private float tempInterval;

    #endregion

    #region Functions


    public void StartSpawner()
    {
        tempInterval = spawnInterval.Amount * spawnIntervalMultiplier.Amount;
        StartCoroutine(SpawnCountdown());
    }

    private void PauseSpawner()
    {
        StopCoroutine(SpawnCountdown());
    }
    public void StopSpawner()
    {
        StopCoroutine(SpawnCountdown());
    }

    private void Spawn(Transform spawnerTransform)
    {
        Vector3 spawnPosition = new Vector3(spawnerTransform.position.x, 0, spawnerTransform.position.z);
        var enemy = enemyPools[Random.Range(0, enemyPools.Count)].GetFromPool();
        enemy.SetTransformAndPosition(spawnPosition);
        enemy.gameObject.SetActive(true);
    }

    private IEnumerator SpawnCountdown()
    {
        while (true)
        {
            while (tempInterval > 0 && stateData.CurrentState == States.PLAY)
            {
                tempInterval -= Time.deltaTime;
                yield return null;
                continue;
            }
            if (stateData.CurrentState == States.STOP)
            {
                PauseSpawner();
                yield break;
            }
            Spawn(spawners[Random.Range(0, spawners.Length)]);
            tempInterval = spawnInterval.Amount * spawnIntervalMultiplier.Amount;
        }
    }


    #endregion

}
