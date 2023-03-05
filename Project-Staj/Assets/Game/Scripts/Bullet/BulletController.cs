using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private BulletData bulletData;
    [SerializeField] private BulletPooler bulletPooler;
    public BulletPooler BulletPooler { get => bulletPooler; set => bulletPooler = value; }

    private void OnEnable()
    {
        Invoke("DestroyBullet", 2f);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent(out BaseEnemy enemyController))
        {
            enemyController.GetDamage(bulletData.Damage);
            DestroyBullet();
            return;
        }
        if (collider.TryGetComponent(out RockController rc))
        {
            DestroyBullet();
        }
    }
    public void DestroyBullet()
    {
        BulletPooler.PutToPool(this);
    }
}
