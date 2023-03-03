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
    [SerializeField] private float countdown;
    private int diagonalAmount = 3;


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
            if (stateData.CurrentState == States.STOP)
            {
                StopCoroutine(FireBullet());
                yield break;
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
                    int angle = diagonalAmount/2*(-30);
                    for (int j = 0; j < diagonalAmount; j++)
                    {
                        ObjectPooler.Instance.SpawnFromPool("bullet", bulletSpawner.position, transform.rotation * Quaternion.Euler(0, angle, 0));
                        angle += 30;
                    }


                    //ObjectPooler.Instance.SpawnFromPool("bullet", bulletSpawner.position, transform.rotation * Quaternion.Euler(0, 30, 0));
                    //ObjectPooler.Instance.SpawnFromPool("bullet", bulletSpawner.position, transform.rotation * Quaternion.Euler(0, -30, 0));
                    //ObjectPooler.Instance.SpawnFromPool("bullet", bulletSpawner.position, transform.rotation);
                }

                yield return new WaitForSeconds(0.3f);
            }
            countdown = playerData.FireInterval;
        }
    }
}
