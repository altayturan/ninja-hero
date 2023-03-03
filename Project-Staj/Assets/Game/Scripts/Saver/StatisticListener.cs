using System.Collections;
using UnityEngine;

public class StatisticListener : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private GameStatistics gameStatistics;
    [SerializeField] private StateData stateData;

    public void IncreaseFiredBullet()
    {
        gameStatistics.TotalFiredBullet+=playerData.BulletAmount;

    }

    public void IncreaseKilledEnemy()
    {
        gameStatistics.TotalKilledEnemy++;
    }
    public void IncreaseTotalDie()
    {
        gameStatistics.TotalDie++;
    }

    public void StartGamePlayTimer()
    {
        StartCoroutine(IncreaseGamePlayTime());
    }
    private IEnumerator IncreaseGamePlayTime()
    {
        while (true)
        {
            if (stateData.CurrentState == States.PLAY)
            {
                gameStatistics.TotalGameplayTime += Time.deltaTime;
                yield return null;
                continue;
            }
            StopCoroutine(IncreaseGamePlayTime());
            yield break;
        }
    }

}
