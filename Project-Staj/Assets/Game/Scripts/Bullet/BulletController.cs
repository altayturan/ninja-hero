using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void Start()
    {
        DestroyBullet(2f);
    }
    private void OnCollisionEnter(Collision collision)//trigger
    {
        if (collision.collider.TryGetComponent(out EnemyController enemyController))
        {
            DestroyBullet();
        }
        if (collision.collider.CompareTag("Rock"))
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
