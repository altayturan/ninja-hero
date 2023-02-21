using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stat", menuName = "Create Stat")]
public class Stat : ScriptableObject
{
    [SerializeField] private float amount;
    [SerializeField] private float cooldown;

    public float Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    public float Cooldown
    {
        get { return cooldown; }
        set { cooldown = value; }   
    }

    
}
