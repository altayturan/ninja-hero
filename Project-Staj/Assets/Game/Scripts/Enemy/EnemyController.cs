using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    #region Variables
    [SerializeField] private float health;
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    [SerializeField] private Animator animator;

    [SerializeField] private GameEvent EnemyOnDie;

    public float Damage
    {
        get
        {
            return damage;
        }
    }

    public float Speed
    {
        get
        {
            return speed;
        }
    }
    #endregion

    #region Monobehavior Functions
    private void Start()
    {
        health *= StatisticManager.Instance.enemyHealthMultiplier;
        animator.SetBool("isRunning", true);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out PlayerController playerController))
        {
            GameManager.Instance.enemyControllers.Remove(this);
            Destroy(this.gameObject);
        }

        if (collision.collider.TryGetComponent(out BulletController bulletController))
        {
            health -= bulletController.BulletDamage;
            if (health <= 0)
            {
                Destroy(gameObject);
                EnemyOnDie.Invoke();
            }
        }
    }
    #endregion
}
