using UnityEngine;

public class BulletResetter : MonoBehaviour
{
    [SerializeField] private BulletData bulletData;


    public void RestartBullet()
    {
        bulletData.Damage = bulletData.BaseDamage;
        bulletData.Speed = bulletData.BaseSpeed;
    }
}
