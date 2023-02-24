using UnityEngine;
using ninjahero.events;
using Unity.VisualScripting;

public class EnemyController : MonoBehaviour
{

    #region Variables
    [SerializeField] private Animator animator;
    [SerializeField] private GameEvent EnemyOnDie;
    [SerializeField] private GameEvent OnGoldChange;
    [SerializeField] private BulletData bulletData;
    [SerializeField] private EnemyData enemyData;
    [SerializeField] private Stat enemyHealthMultiplier;
    [SerializeField] private Resource gold;


    private float defaultHealth;
    private float defaultDamage;
    private float defaultSpeed;
    private int defaultPrize;

    private float damageFromSkill = 200f;

    private void Start()
    {
        enemyData.Health *= enemyHealthMultiplier.Amount;

        defaultDamage = enemyData.Damage;
        defaultPrize = enemyData.Prize;
        defaultSpeed = enemyData.Speed;
        defaultHealth = enemyData.Health;

        animator.SetBool("isRunning", true);
    }

    public float GetDamage()
    {
        return enemyData.Damage;
    }

    public EnemyData GetEnemyData()
    {
        return enemyData;
    }
    #endregion

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out PlayerController playerController))
        {
            Destroy(gameObject);
        }

        if (collision.collider.TryGetComponent(out BulletController bulletController))
        {
            enemyData.Health -= bulletData.Damage;
            CheckForDie();
        }
    }
    public void GetDamageFromSkill()
    {
        enemyData.Health -= damageFromSkill;
        CheckForDie();
    }

    public void RestartEnemy()
    {
        enemyData.Health = defaultHealth;
        enemyData.Speed = defaultSpeed;
        enemyData.Damage= defaultDamage;
        enemyData.Prize = defaultPrize;

        Destroy(gameObject);
    }
    public bool CheckForDie()
    {
        if (enemyData.Health <= 0)
        {
            gold.Amount += enemyData.Prize;
            EnemyOnDie.Invoke();
            OnGoldChange.Invoke();
            Destroy(gameObject);
            return true;
        }
        return false;
    }
}
