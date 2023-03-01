using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private Transform[] spawners;
    [SerializeField] private List<string> enemyTags;
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
        ObjectPooler.Instance.SpawnFromPool(enemyTags[Random.Range(0, enemyTags.Count)], spawnPosition, Quaternion.identity);
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
