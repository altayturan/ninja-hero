using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    #region Variables
    [SerializeField] private float speed;
    private Rigidbody rb;
    private Vector3 direction;


    public Transform target;
    #endregion

    #region Monobehavior Functions
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        transform.LookAt(target);
        direction = (target.position - transform.position).normalized;
    }
    private void FixedUpdate()
    {
        Move();
    }

    #endregion


    #region Functions

    private void Move()
    {
        rb.velocity = direction * speed;
    }

    #endregion

}
