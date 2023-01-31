using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private float bulletDamage;

    private void Start()
    {
        bulletDamage = StatisticManager.Instance.bulletDamage;
        Destroy(this.gameObject,6f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            GiveDamage(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.collider.CompareTag("Rock"))
        {
            Destroy(this.gameObject);
        }
    }

    public void GiveDamage(GameObject target)
    {
        if (target.GetComponent<EnemyController>() == null) return;
        target.GetComponent<EnemyController>().ChangeHealthWithAmount(-bulletDamage);
    }
}
