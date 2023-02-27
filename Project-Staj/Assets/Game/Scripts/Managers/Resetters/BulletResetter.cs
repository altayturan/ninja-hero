using UnityEngine;

public class BulletResetter : MonoBehaviour
{
    [SerializeField] private BulletData bulletData;


    public void ResetBullet()
    {
        bulletData.Damage = bulletData.BaseDamage;
        bulletData.Speed = bulletData.BaseSpeed;
    }
}
