using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private Transform[] spawners;
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private Stat spawnInterval;

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
        Vector3 spawnPosition = new Vector3(spawnerTransform.position.x, 0, spawnerTransform.position.z);
        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPosition, Quaternion.identity);
    }

    private IEnumerator SpawnCountdown()
    {
        Spawn(spawners[Random.Range(0, spawners.Length)]);
        yield return new WaitForSeconds(spawnInterval.Amount * StatisticManager.Instance.spawnIntervalMultiplier);
        yield return SpawnCountdown();
    }


    #endregion

}
