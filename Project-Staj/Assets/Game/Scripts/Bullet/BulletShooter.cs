using System.Collections;
using UnityEngine;
using ninjahero.events;
public class BulletShooter : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawner;
    [SerializeField] private GameEvent OnFireEvent;
    [SerializeField] private BulletPooler bulletPool;
    [SerializeField] private BulletData bulletData;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private StateData stateData;
    [SerializeField] private float countdown;


    public void StartFireBullet()
    {
        countdown = playerData.FireInterval;
        StartCoroutine(FireBullet());
    }
    private IEnumerator FireBullet()
    {
        while (true)
        {
            if (countdown > 0 && stateData.CurrentState == States.PLAY)
            {
                countdown -= Time.deltaTime;
                yield return null;
                continue;
            }
            if (stateData.CurrentState == States.PAUSE || stateData.CurrentState == States.STOP)
            {
                StopCoroutine(FireBullet());
                yield break;
            }
            for (int i = 0; i < playerData.NumberOfShots; i++)
            {
                OnFireEvent.Invoke();
                var rotation = transform.rotation;
                int angle = playerData.BulletAmount / 2 * (-80);
                for (int j = 0; j < playerData.BulletAmount; j++)
                {
                    var bullet = bulletPool.GetFromPool();
                    bullet.transform.position = bulletSpawner.transform.position;
                    bullet.transform.rotation = rotation * Quaternion.Euler(0, angle, 0);
                    angle += 80;
                }
                yield return new WaitForSeconds(0.3f);
            }
            countdown = playerData.FireInterval;
        }
    }
}
