using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private Transform[] spawners;
    [SerializeField] private Stat spawnInterval;
    [SerializeField] private Stat spawnIntervalMultiplier;
    [SerializeField] private StateData stateData;

    [SerializeField] private SpeedyPooler speedyPooler;
    [SerializeField] private TankPooler tankPooler;
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
        BaseEnemy enemy = Random.Range(0,2) == 0 ? speedyPooler.GetFromPool() : tankPooler.GetFromPool(); 
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
