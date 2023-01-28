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
    public float health;
    public float speed;
    public GameObject bulletObject;

    public float fireInterval = 2f;
    public int numberOfShots = 1;
    public bool diagonalShot = false;

    private float range = 6.5f;
    private Collider[] objectsInRange;
    private GameObject closestEnemy;
    private float closestDistance = Mathf.Infinity;
    #endregion

    #region Monobehavior Functions
    private void Start()
    {
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
            transform.LookAt(closestEnemy.transform);  // Dönüþler animasyon yapýlacak.
        
        
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


    #region Functions

    private IEnumerator FireBullet()
    {
        for (int i = 0; i < numberOfShots; i++)
        {
            if (!diagonalShot) { Instantiate(bulletObject, transform.position, transform.rotation); }
            else
            {
                Instantiate(bulletObject, transform.position, transform.rotation * Quaternion.Euler(0, 30, 0));  // Þimdilik sadece 3 atýþlýk bir kod ama shot sayýsýna göre otomatik açý
                Instantiate(bulletObject, transform.position, transform.rotation * Quaternion.Euler(0, -30, 0)); // ayarlayan bir kod yazýlabilir.
                Instantiate(bulletObject, transform.position, transform.rotation);
            }
            yield return new WaitForSeconds(0.3f);
        }
        yield return new WaitForSeconds(fireInterval);
        yield return FireBullet();
    }


    #endregion
}
