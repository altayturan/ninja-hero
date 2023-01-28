using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private Transform[] spawners;
    [SerializeField] private float defaultSpawnInterval = 3f;
    [SerializeField] private GameObject enemyObject;

    #endregion

    #region Monobehavior Functions
    private void Start()
    {
        StartCoroutine(SpawnCountdown());
    }
    #endregion


    #region Functions

    private void Spawn(Transform spawnerTransform)
    {
        Vector3 spawnPosition = new Vector3(spawnerTransform.position.x, 0.5f, spawnerTransform.position.z);
        GameObject spawnedEnemy = Instantiate(enemyObject, spawnPosition, Quaternion.identity);
    }

    private IEnumerator SpawnCountdown()
    {
        Spawn(spawners[Random.Range(0, spawners.Length)]);
        yield return new WaitForSeconds(defaultSpawnInterval * StatisticManager.Instance.spawnIntervalMultiplier);
        yield return SpawnCountdown();
    }


    #endregion

}
