using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private Transform[] spawners;
    [SerializeField] private Stat spawnInterval;
    [SerializeField] private Stat spawnIntervalMultiplier;
    [SerializeField] private StateData stateData;

    [SerializeField] private SpeedyPooler speedyPooler;
    [SerializeField] private TankPooler tankPooler;
    private float tempInterval;

    private void Start()
    {
        tempInterval = spawnInterval.Amount * spawnIntervalMultiplier.Amount;
    }

    private void Spawn(Transform spawnerTransform)
    {
        Vector3 spawnPosition = new Vector3(spawnerTransform.position.x, 0, spawnerTransform.position.z);
        BaseEnemy enemy = Random.Range(0, 2) == 0 ? speedyPooler.GetFromPool() : tankPooler.GetFromPool();
        enemy.SetTransformAndPosition(spawnPosition);
        enemy.gameObject.SetActive(true);
    }

    public void CheckForSpawn()
    {
        if (stateData.CurrentState != States.PLAY) return;
        if (tempInterval >= 0)
        {
            tempInterval--;
        }
        else
        {
            Spawn(spawners[Random.Range(0, spawners.Length)]);
            tempInterval = spawnInterval.Amount * spawnIntervalMultiplier.Amount;
        }
    }
}
