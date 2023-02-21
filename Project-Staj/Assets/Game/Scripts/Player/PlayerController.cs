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
    [SerializeField] private GameObject bulletObject;
    [SerializeField] private Transform bulletSpawner;
    [SerializeField] private GameEvent OnPlayerDieEvent;

    [SerializeField] private float range = 10f;
    private Collider[] objectsInRange;
    private GameObject closestEnemy;
    private float closestDistance = Mathf.Infinity;

    public float Health { get { return health; }  }
    public float Speed { get { return speed;} }
    #endregion

    #region Monobehavior Functions
    private void Start()
    {
        health = StatisticManager.Instance.playerHealth;
        speed = StatisticManager.Instance.playerSpeed;

        StartCoroutine(FireBullet());
    }

    private void Update()
    {

        objectsInRange = Physics.OverlapSphere(transform.position, range);

        if (closestEnemy == null)
        {
            closestDistance = Mathf.Infinity;
            transform.eulerAngles = Vector3.zero;
        }
        else
            transform.LookAt(closestEnemy.transform);  


        foreach (Collider collider in objectsInRange)
        {
            if (!collider.CompareTag("Enemy")) continue;

            if (Vector3.Distance(transform.position, collider.transform.position) < closestDistance)
            {
                closestDistance = Vector3.Distance(transform.position, collider.transform.position);
                closestEnemy = collider.gameObject;
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
    #endregion

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent(out EnemyController enemyController))
        {
            health -= enemyController.Damage;
            if (health <= 0)
            {
                OnPlayerDieEvent.Invoke();
            }
        }
    }
    #region Functions

    private IEnumerator FireBullet()
    {
        for (int i = 0; i < StatisticManager.Instance.numberOfShots; i++)
        {
            if (!StatisticManager.Instance.diagonalShot) { Instantiate(bulletObject, bulletSpawner.position, transform.rotation); }
            else
            {
                Instantiate(bulletObject, bulletSpawner.position, transform.rotation * Quaternion.Euler(0, 30, 0));  // Þimdilik sadece 3 atýþlýk bir kod ama shot sayýsýna göre otomatik açý
                Instantiate(bulletObject, bulletSpawner.position, transform.rotation * Quaternion.Euler(0, -30, 0)); // ayarlayan bir kod yazýlabilir.
                Instantiate(bulletObject, bulletSpawner.position, transform.rotation);
            }
            yield return new WaitForSeconds(0.3f);
        }
        yield return new WaitForSeconds(StatisticManager.Instance.fireInterval);
        yield return FireBullet();
    }
    

    
    #endregion
}
