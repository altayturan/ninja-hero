using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawner;
    [SerializeField] private GameEvent OnFireEvent;

    [SerializeField] private BulletData bulletData;
    [SerializeField] private PlayerData playerData;
    private void Start()
    {
        StartCoroutine(FireBullet());
    }

    private IEnumerator FireBullet()
    {
        OnFireEvent.Invoke();
        for (int i = 0; i < playerData.NumberOfShots; i++)
        {
            if (!playerData.DiagonalShot) { Instantiate(bulletData.BulletObject, bulletSpawner.position, transform.rotation); }
            else
            {
                Instantiate(bulletData.BulletObject, bulletSpawner.position, transform.rotation * Quaternion.Euler(0, 30, 0));  // Þimdilik sadece 3 atýþlýk bir kod ama shot sayýsýna göre otomatik açý
                Instantiate(bulletData.BulletObject, bulletSpawner.position, transform.rotation * Quaternion.Euler(0, -30, 0)); // ayarlayan bir kod yazýlabilir.
                Instantiate(bulletData.BulletObject, bulletSpawner.position, transform.rotation);
            }

            yield return new WaitForSeconds(0.3f);
        }
        yield return new WaitForSeconds(playerData.FireInterval);
        yield return FireBullet();
    }
}
