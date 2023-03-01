using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private Transform[] spawners;
    [SerializeField] private List<string> enemyTags;
    [SerializeField] private Stat spawnInterval;
    [SerializeField] private Stat spawnIntervalMultiplier;

    [SerializeField] private StateData stateData;

    #endregion

    #region Functions

    public void StartSpawner()
    {
        StartCoroutine(SpawnCountdown());
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
            yield return new WaitForSeconds(spawnInterval.Amount * spawnIntervalMultiplier.Amount);
            if (stateData.CurrentState == States.PLAY)
            {
                Spawn(spawners[Random.Range(0, spawners.Length)]);
            }
            else if(stateData.CurrentState == States.STOP)
            {
                StopCoroutine(SpawnCountdown());
            }
        }
    }


    #endregion

}
