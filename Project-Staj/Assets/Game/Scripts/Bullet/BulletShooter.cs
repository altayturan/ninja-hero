using System.Collections;
using UnityEngine;
using ninjahero.events;
public class BulletShooter : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawner;
    [SerializeField] private GameEvent OnFireEvent;

    [SerializeField] private BulletData bulletData;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private StateData stateData;
    private void Start()
    {
        StartCoroutine(FireBullet());
    }

    private IEnumerator FireBullet()
    {
        yield return new WaitUntil(()=>stateData.CurrentState == States.PLAY);
        for (int i = 0; i < playerData.NumberOfShots; i++)
        {
            OnFireEvent.Invoke();

            if (!playerData.DiagonalShot)
            {
                ObjectPooler.Instance.SpawnFromPool("bullet", bulletSpawner.position, transform.rotation);
            }
            else
            {
                ObjectPooler.Instance.SpawnFromPool("bullet", bulletSpawner.position, transform.rotation * Quaternion.Euler(0, 30, 0));
                ObjectPooler.Instance.SpawnFromPool("bullet", bulletSpawner.position, transform.rotation * Quaternion.Euler(0, -30, 0));
                ObjectPooler.Instance.SpawnFromPool("bullet", bulletSpawner.position, transform.rotation);
            }

            yield return new WaitForSeconds(0.3f);
        }
        yield return new WaitForSeconds(playerData.FireInterval);
        yield return FireBullet();
    }
}
