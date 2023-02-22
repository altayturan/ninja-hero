using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ninjahero.events;
public class PlayerController : MonoBehaviour
{
    #region Variables

    [SerializeField] private PlayerData playerData;
    [SerializeField] private GameEvent OnPlayerDieEvent;
    [SerializeField] private TargetEnemy targetEnemy;

    #endregion

    #region Monobehavior Functions
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
    #endregion

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out EnemyController enemyController))
        {
            playerData.Health -= enemyController.GetDamage();
            if (playerData.Health <= 0)
            {
                OnPlayerDieEvent.Invoke();
            }
        }
    }
}
