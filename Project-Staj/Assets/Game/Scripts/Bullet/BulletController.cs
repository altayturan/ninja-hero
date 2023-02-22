using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void Start()
    {
        Destroy(this.gameObject, 6f);
    }
    private void OnCollisionEnter(Collision collision)
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
}
