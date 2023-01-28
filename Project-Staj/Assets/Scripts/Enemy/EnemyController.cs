using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{



    #region Variables
    public float health;
    public float speed;
    public float damage;
    #endregion

    #region Monobehavior Functions
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GiveDamage(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
    #endregion


    #region Functions
    public void GiveDamage(GameObject target)
    {
        target.GetComponent<PlayerController>().health -= damage;
    }

    #endregion
}
