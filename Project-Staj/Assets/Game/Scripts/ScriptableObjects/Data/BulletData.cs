using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet Data", menuName = "Data/Create Bullet Data")]
public class BulletData : ScriptableObject
{
    [SerializeField] private float damage;
    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletObject;


    public float Speed { get { return speed; } set { speed = value; } }
    public float Damage { get { return damage; } set { damage = value; } }
    public GameObject BulletObject { get { return bulletObject; } }
}
