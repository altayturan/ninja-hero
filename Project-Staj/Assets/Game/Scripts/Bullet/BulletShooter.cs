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

    private float countdown;
    private void Start()
    {
    }
    public void StartFireBullet()
    {
        StartCoroutine(FireBullet());
    }
    private IEnumerator FireBullet()
    {
        while (true)
        {
            countdown = playerData.FireInterval;
            while (countdown > 0 && stateData.CurrentState == States.PLAY)
            {
                countdown -= Time.fixedDeltaTime;
                yield return null;
            }
            if(stateData.CurrentState == States.STOP)
            {
                StopCoroutine(FireBullet());
            }
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
        }
    }
}
