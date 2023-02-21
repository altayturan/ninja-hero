using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet Data",menuName ="Data/Create Bullet Data")]
public class BulletData : ScriptableObject
{
    [SerializeField] private int damage;
    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletObject;


    public float Speed { get { return speed; } }
    public int Damage { get { return damage; } }
    public GameObject BulletObject { get { return bulletObject; } }
}
