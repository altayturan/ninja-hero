using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform playerTransform;
    private Rigidbody rb;
    private Vector3 direction;

    [SerializeField] private EnemyData enemyData;

    private void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
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

    private void Move()
    {
        rb.velocity = direction * enemyData.Speed;
    }


}
