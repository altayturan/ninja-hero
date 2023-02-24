using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletResetter : MonoBehaviour
{
    [SerializeField] private BulletData bulletData;

    private float defaultDamage;
    private float defaultSpeed;
    private void Start()
    {
        defaultDamage = bulletData.Damage;
        defaultSpeed = bulletData.Speed;
    }

    public void RestartBullet()
    {
        bulletData.Damage = defaultDamage;
        bulletData.Speed = defaultSpeed;
    }
}
