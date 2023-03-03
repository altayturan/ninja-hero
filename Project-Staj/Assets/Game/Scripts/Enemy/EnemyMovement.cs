using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 direction;

    [SerializeField] private EnemyData enemyData;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private StateData stateData;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();//drag drop
    }
    private void FixedUpdate()
    {
        if (stateData.CurrentState == States.PLAY)
        {
            transform.LookAt(playerData.Transform);
            direction = (playerData.Transform.position - transform.position).normalized;
            rb.velocity = direction * enemyData.Speed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
