using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Singleton
    private PlayerController playerController;
    private static PlayerController _instance;

    public static PlayerController Instance { get { return _instance; } }

    private void Awake()
    {

        if (_instance != null && _instance != this)  // SINGLETON
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        playerController = new PlayerController();
    }
    #endregion

    #region Variables
    public float health;
    public float speed;
    public float damageMultiplier = 1.1f;
    #endregion

    #region Monobehavior Functions
    #endregion


    #region Functions

    public void GiveDamage(GameObject target, float damage)
    {
        if (target.GetComponent<EnemyController>() == null) return;

        target.GetComponent<EnemyController>().health -= damage;
    }


    #endregion
}
