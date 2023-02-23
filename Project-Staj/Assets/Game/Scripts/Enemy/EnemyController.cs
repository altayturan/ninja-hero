using UnityEngine;
using ninjahero.events;
public class EnemyController : MonoBehaviour
{

    #region Variables
    [SerializeField] private Animator animator;
    [SerializeField] private GameEvent EnemyOnDie;
    [SerializeField] private GameEvent OnGoldChange;
    [SerializeField] private BulletData bulletData;
    [SerializeField] private EnemyData enemyData;
    [SerializeField] private Stat enemyHealthMultiplier;

    public float GetDamage()
    {
        return enemyData.Damage;
    }

    public EnemyData GetEnemyData()
    {
        return enemyData;
    }
    #endregion

    #region Monobehavior Functions
    private void Start()
    {
        enemyData.Health *= enemyHealthMultiplier.Amount;
        animator.SetBool("isRunning", true);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out PlayerController playerController))
        {
            Destroy(gameObject);
        }

        if (collision.collider.TryGetComponent(out BulletController bulletController))
        {
            enemyData.Health -= bulletData.Damage;
            if (enemyData.Health <= 0)
            {
                Destroy(gameObject);
                EnemyOnDie.Invoke();
                OnGoldChange.Invoke();
            }
        }
    }
    #endregion
}
