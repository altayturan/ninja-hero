using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : ScriptableObject
{
    [SerializeField] protected int cost;
    [SerializeField] protected int level;

    public virtual int Level { get { return level; } set { level = value; } }
    public int Cost { get { return cost; } set { cost = value; } }
}
