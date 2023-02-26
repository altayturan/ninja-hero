using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private BulletData bulletData;
    private float bulletDamage;
    private void Start()
    {
        bulletDamage = bulletData.Damage;
        Destroy(this.gameObject, 6f);
    }
    private void OnCollisionEnter(Collision collision)//trigger
    {
        if (collision.collider.TryGetComponent(out EnemyController enemyController))
        {
            Destroy(this.gameObject);
        }
        if (collision.collider.CompareTag("Rock"))
        {
            Destroy(this.gameObject);
        }
    }

    public void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
