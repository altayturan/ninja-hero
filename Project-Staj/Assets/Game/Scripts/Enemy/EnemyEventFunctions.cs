using UnityEngine;

public class EnemyEventFunctions : MonoBehaviour
{
    [SerializeField] private Resource gold;
    public void KillEnemy()
    {
        gold.Amount += 30;
    }
}
