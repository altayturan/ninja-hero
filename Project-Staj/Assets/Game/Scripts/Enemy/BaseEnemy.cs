using ninjahero.events;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameEvent EnemyOnDie;
    [SerializeField] private GameEvent OnGoldChange;
    [SerializeField] private BulletData bulletData;
    [SerializeField] private EnemyData enemyData;
    [SerializeField] private Stat enemyHealthMultiplier;
    [SerializeField] private Resource gold;

    [SerializeField] private float health;
    private float damageFromSkill = 200f;
    private void Start()
    {
        health = enemyData.Health * enemyHealthMultiplier.Amount;
        animator.SetBool("isRunning", true);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent(out PlayerController playerController))
        {
            playerController.GetDamage(enemyData.Damage);
            DestroyEnemy();
        }
    }
    public void GetDamageFromSkill()
    {
        health -= damageFromSkill;
        CheckForDie();
    }
    public void GetDamage(float damage)
    {
        health -= damage;
        CheckForDie();
    }
    public void CheckForDie()
    {
        if (health <= 0)
        {
            gold.Amount += enemyData.Prize;
            EnemyOnDie.Invoke();
            DestroyEnemy();
        }
    }
    public abstract void DestroyEnemy();

    public void SetTransformAndPosition(Vector3 pos)
    {
        transform.position = pos;
    }
}
