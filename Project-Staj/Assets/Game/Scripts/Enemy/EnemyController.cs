using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    #region Variables
    [SerializeField] private Animator animator;
    [SerializeField] private GameEvent EnemyOnDie;
    [SerializeField] private BulletData bulletData;
    [SerializeField] private EnemyData enemyData;
    [SerializeField] private float enemyHealthMultiplier;

    #endregion

    #region Monobehavior Functions
    private void Start()
    {
        enemyData.Health *= enemyHealthMultiplier;
        animator.SetBool("isRunning", true);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out PlayerController playerController))
        {
            Destroy(this.gameObject);
        }

        if (collision.collider.TryGetComponent(out BulletController bulletController))
        {
            enemyData.Health -= bulletData.Damage;
            if (enemyData.Health <= 0)
            {
                Destroy(gameObject);
                EnemyOnDie.Invoke();
            }
        }
    }
    #endregion
}
