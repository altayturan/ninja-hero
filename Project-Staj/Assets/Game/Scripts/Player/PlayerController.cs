using UnityEngine;
using ninjahero.events;
public class PlayerController : MonoBehaviour
{

    [SerializeField] private PlayerData playerData;
    [SerializeField] private GameEvent OnPlayerGetDamage;
    [SerializeField] private TargetEnemy targetEnemy;
    [SerializeField] private GameEvent OnLoseGameEvent;
    private void Start()
    {
        playerData.Transform = transform;
    }

    public void RotatePlayer()
    {
        if (targetEnemy.GetTarget(out Transform target))
            transform.LookAt(target);
        else
            transform.eulerAngles = Vector3.zero;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, playerData.Range);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out EnemyController enemyController))
        {
            playerData.Health -= enemyController.GetDamage();
            if (playerData.Health <= 0)
            {
                OnLoseGameEvent.Invoke();
            }
        }
    }
}
