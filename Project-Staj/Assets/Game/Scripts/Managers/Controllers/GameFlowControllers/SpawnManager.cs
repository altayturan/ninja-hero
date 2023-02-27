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

    #region Monobehavior Functions
    private void Start()
    {
        List<string> list = new List<string>();
        StartCoroutine(SpawnCountdown());
    }
    #endregion


    #region Functions

    private void Spawn(Transform spawnerTransform)
    {
        Vector3 spawnPosition = new Vector3(spawnerTransform.position.x, 0, spawnerTransform.position.z);
        ObjectPooler.Instance.SpawnFromPool(enemyTags[Random.Range(0, enemyTags.Count)], spawnPosition, Quaternion.identity);
    }

    private IEnumerator SpawnCountdown()
    {
        if (stateData.CurrentState == States.PLAY)
        {
            yield return new WaitForSeconds(spawnInterval.Amount * spawnIntervalMultiplier.Amount);
            Spawn(spawners[Random.Range(0, spawners.Length)]);
        }
        yield return SpawnCountdown();
    }


    #endregion

}
