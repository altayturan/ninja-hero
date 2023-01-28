using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float bulletDamage;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            GiveDamage(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

    public void GiveDamage(GameObject target)
    {
        if (target.GetComponent<EnemyController>() == null) return;
        target.GetComponent<EnemyController>().health -= bulletDamage;
    }
}
