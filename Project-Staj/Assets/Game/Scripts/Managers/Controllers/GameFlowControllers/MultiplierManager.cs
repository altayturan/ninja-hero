using UnityEngine;

public class MultiplierManager : MonoBehaviour
{
    [SerializeField] private Stat enemyHealthMultiplier;
    [SerializeField] private Stat spawnIntervalMultiplier;
    [SerializeField] private StateData stateData;
    [SerializeField] private int enemyHealthCooldown;
    [SerializeField] private int spawnIntervalCooldown;


    public void CheckHealthMultiplyCooldown()
    {
        if (stateData.CurrentState != States.PLAY) return;
        if (enemyHealthCooldown >= 0)
        {
            enemyHealthCooldown--;
        }
        else
        {
            enemyHealthMultiplier.Amount *= 1.1f;
            enemyHealthCooldown = 3;
        }
    }
    public void CheckSpawnIntervalMultiplyCooldown()
    {
        if (stateData.CurrentState != States.PLAY) return;
        if (spawnIntervalCooldown >= 0)
        {
            spawnIntervalCooldown--;
        }
        else
        {
            spawnIntervalMultiplier.Amount *= 0.9f;
            spawnIntervalCooldown = 3;
        }
    }

}
