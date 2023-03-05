using ninjahero.events;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private BulletData bulletData;
    [SerializeField] private BulletPooler bulletPooler;
    public BulletPooler BulletPooler { get => bulletPooler; set => bulletPooler = value; }

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
        BulletPooler.PutToPool(this);
    }
    private void DestroyBullet(float t)
    {
        var startTime = Time.time;
        if (Time.time - startTime > t)
        {
            BulletPooler.PutToPool(this);
        }
    }
}
