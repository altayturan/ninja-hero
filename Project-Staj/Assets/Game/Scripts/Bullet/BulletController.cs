using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private BulletData bulletData;
    [SerializeField] private StateData stateData;
    [SerializeField] private int timeout = 2;
    private BulletPooler bulletPooler;
    public BulletPooler BulletPooler { get => bulletPooler; set => bulletPooler = value; }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent(out BaseEnemy enemyController))
        {
            enemyController.GetDamage(bulletData.Damage);
            DestroyBullet();
            return;
        }
        if (collider.TryGetComponent<RockController>(out _))
        {
            DestroyBullet();
        }
    }
    private void DestroyBullet()
    {
        BulletPooler.PutToPool(this);
    }

    public void CheckForTimeout()
    {
        if (stateData.CurrentState != States.PLAY) return;
        if (timeout >= 0)
        {
            timeout--;
        }
        else
        {
            DestroyBullet();
            timeout = 3;
        }
    }
}
