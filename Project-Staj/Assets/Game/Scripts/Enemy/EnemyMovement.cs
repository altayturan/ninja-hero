using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    #region Variables
    private EnemyController enemyController;
    private Transform playerTransform;
    private Rigidbody rb;
    private Vector3 direction;
    #endregion

    #region Monobehavior Functions
    private void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        enemyController = GetComponent<EnemyController>();
    }
    private void Update()
    {
        transform.LookAt(playerTransform);
        direction = (playerTransform.position - transform.position).normalized;
    }
    private void FixedUpdate()
    {
        Move();
    }


    #endregion


    #region Functions

    private void Move()
    {
        rb.velocity = direction * enemyController.Speed;
    }

    #endregion

}
