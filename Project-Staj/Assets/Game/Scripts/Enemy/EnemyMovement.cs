using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 direction;

    [SerializeField] private EnemyData enemyData;
    [SerializeField] private PlayerData playerData;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();//drag drop
    }
    private void Update()
    {
        transform.LookAt(playerData.Transform);
        direction = (playerData.Transform.position - transform.position).normalized;
    }
    private void FixedUpdate()
    {
        rb.velocity = direction * enemyData.Speed;
    }


}
