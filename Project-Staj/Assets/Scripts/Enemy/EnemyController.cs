using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    #region Variables
    [SerializeField] private float health;
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    #endregion

    #region Monobehavior Functions
    private void Start()
    {
        health *= StatisticManager.Instance.enemyHealthMultiplier;
    }

    private void Update()
    {
        if (health <= 0) Destroy(gameObject);
        Debug.Log(Time.timeSinceLevelLoad);
    }
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
        target.GetComponent<PlayerController>().ChangeHealthWithAmount(-damage);
    }

    public void ChangeHealthWithAmount(float changeAmount)
    {
        health += changeAmount;
    }

    public float GetSpeed()
    {
        return speed;
    }

    #endregion
}
