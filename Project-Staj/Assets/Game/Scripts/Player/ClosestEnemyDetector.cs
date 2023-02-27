using UnityEngine;

public class ClosestEnemyDetector : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private TargetEnemy targetEnemy;
    
    private Collider[] objectsInRange;
    private Transform closestEnemy;
    private float closestDistance;

    public void SetTarget()
    {
        closestDistance = Mathf.Infinity;
        closestEnemy = null;

        objectsInRange = Physics.OverlapSphere(transform.position, playerData.Range);

        foreach (Collider collider in objectsInRange)
        {
            if (!collider.TryGetComponent(out EnemyController ec)) continue;

            if (Vector3.Distance(transform.position, collider.transform.position) < closestDistance)
            {
                closestDistance = Vector3.Distance(transform.position, collider.transform.position);
                closestEnemy = collider.transform;
            }
        }
        targetEnemy.Target = closestEnemy;
    }
}
