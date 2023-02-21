using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Singleton
    private PlayerController playerController;
    private static PlayerController _instance;

    public static PlayerController Instance { get { return _instance; } }

    private void Awake()
    {

        if (_instance != null && _instance != this)  // SINGLETON
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        playerController = new PlayerController();
    }
    #endregion

    #region Variables
    private float health;
    private float speed;
    [SerializeField] private GameEvent OnPlayerDieEvent;
    [SerializeField] private TargetEnemy targetEnemy;
    [SerializeField] private Stat range;



    public float Health { get { return health; } }
    public float Speed { get { return speed; } }
    #endregion

    #region Monobehavior Functions
    private void Start()
    {
        health = StatisticManager.Instance.playerHealth;
        speed = StatisticManager.Instance.playerSpeed;

    }
    public void RotatePlayer()
    {
        if (targetEnemy.GetTarget(out Transform target))
            transform.LookAt(target);
        else
            transform.eulerAngles = Vector3.zero;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range.Amount);
    }
    #endregion

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out EnemyController enemyController))
        {
            health -= enemyController.Damage;
            if (health <= 0)
            {
                OnPlayerDieEvent.Invoke();
            }
        }
    }
}
