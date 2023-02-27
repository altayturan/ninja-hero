using UnityEngine;
using ninjahero.events;

public class EnemyController : MonoBehaviour
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
    private float tempSpeed;

    private void Start()
    {
        health = enemyData.Health * enemyHealthMultiplier.Amount;
        animator.SetBool("isRunning", true);
    }

    public float GetDamage()
    {
        return enemyData.Damage;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out PlayerController playerController))
        {
            DestroyEnemy();
        }

        else if (collision.collider.TryGetComponent(out BulletController bulletController))
        {
            health -= bulletData.Damage;
            CheckForDie();
        }
    }
    public void GetDamageFromSkill()
    {
        health -= damageFromSkill;
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
    public void DestroyEnemy()
    {
        gameObject.SetActive(false);
    }
    public void StopEnemy()
    {
        Debug.Log("Girdi");
        tempSpeed = enemyData.Speed;
        enemyData.Speed = 0;
        animator.SetBool("isRunning", false);
    }

    public void StartEnemy()
    {
        enemyData.Speed = tempSpeed;
        animator.SetBool("isRunning", true);
    }
}
