using UnityEngine;
using ninjahero.events;
public class PlayerController : MonoBehaviour
{
    #region Variables

    [SerializeField] private PlayerData playerData;
    [SerializeField] private GameEvent OnPlayerDieEvent;
    [SerializeField] private GameEvent OnPlayerGetDamage;
    [SerializeField] private TargetEnemy targetEnemy;
    [SerializeField] private GameEvent OnLoseGameEvent;

    private float defaultSpeed;
    private float defaultHealth;
    private float defaultFireInterval;
    private int defaultNumbeOfShots;
    private float defaultRange;
    private bool defaultDiagonalShot;

    #endregion
    private void Start()
    {
        playerData.Transform = transform;

        defaultSpeed = playerData.Speed;
        defaultHealth = playerData.Health;
        defaultFireInterval = playerData.FireInterval;
        defaultNumbeOfShots = playerData.NumberOfShots;
        defaultRange = playerData.Range;
        defaultDiagonalShot = playerData.DiagonalShot;
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
            OnPlayerGetDamage.Invoke();
            if (playerData.Health <= 0)
            {
                OnLoseGameEvent.Invoke();
            }
        }
    }

    public void ResetPlayer()
    {
        playerData.Health = defaultHealth;
        playerData.Speed = defaultSpeed;
        playerData.Range = defaultRange;
        playerData.DiagonalShot = defaultDiagonalShot;
        playerData.FireInterval = defaultFireInterval;
        playerData.NumberOfShots = defaultNumbeOfShots;
    }
}
