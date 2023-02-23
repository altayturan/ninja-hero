using UnityEngine;

public class EnemyGoldGainController : MonoBehaviour
{
    [SerializeField] private Resource gold;
    public void KillEnemy()
    {
        gold.Amount += 30;
    }
}
