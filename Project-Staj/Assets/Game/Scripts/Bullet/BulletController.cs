using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private BulletData bulletData;
    private void Start()
    {
        DestroyBullet(2f);
    }
    private void OnCollisionEnter(Collision collision)//trigger
    {
        if (collision.collider.TryGetComponent(out EnemyController enemyController))
        {
            enemyController.GetDamage(bulletData.Damage);
            DestroyBullet();
            return;
        }
        if (collision.collider.TryGetComponent(out RockController rc)) 
        {
            DestroyBullet();
        }
    }

    public void DestroyBullet()
    {
        gameObject.SetActive(false);
    }

    private void DestroyBullet(float t)
    {
        var startTime = Time.time;
        if (Time.time - startTime > t)
        {
            gameObject.SetActive(false);
        }
    }
}
