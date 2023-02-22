using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    #region Variables
    [SerializeField] private TargetEnemy targetEnemy;
    [SerializeField] private BulletData bulletData;

    private Vector3 direction;
    #endregion

    #region Monobehavior Functions

    private void Start()
    {
        if(targetEnemy.GetTarget(out Transform target))
        {
            direction = target.position - transform.position;
        }
        else
        {
            direction = Vector3.forward;
        }
        GetComponent<Rigidbody>().velocity = direction.normalized * bulletData.Speed;
    }
    #endregion


}
