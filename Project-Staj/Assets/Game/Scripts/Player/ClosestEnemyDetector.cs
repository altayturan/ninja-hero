using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosestEnemyDetector : MonoBehaviour
{
    [SerializeField] private Stat range;
    [SerializeField] private TargetEnemy targetEnemy;
    
    private Collider[] objectsInRange;
    private Transform closestEnemy;
    private float closestDistance;

    public void SetTarget()
    {
        closestDistance = Mathf.Infinity;
        closestEnemy = null;

        objectsInRange = Physics.OverlapSphere(transform.position, range.Amount);

        foreach (Collider collider in objectsInRange)
        {
            if (!collider.CompareTag("Enemy")) continue;

            if (Vector3.Distance(transform.position, collider.transform.position) < closestDistance)
            {
                closestDistance = Vector3.Distance(transform.position, collider.transform.position);
                closestEnemy = collider.transform;
            }
        }
        targetEnemy.Target = closestEnemy;
    }
}
