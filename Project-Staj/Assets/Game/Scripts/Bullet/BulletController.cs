using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private float bulletDamage;


    public float BulletDamage
    {
        get
        {
            return bulletDamage;
        }
    }
    private void Start()
    {
        bulletDamage = StatisticManager.Instance.bulletDamage;
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
