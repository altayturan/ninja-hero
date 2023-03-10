using UnityEngine;

public abstract class Booster : ScriptableObject
{
    [SerializeField] protected int baseCost;
    [SerializeField] protected int baseLevel;

    protected int cost;
    protected int level;


    public virtual int Level { get { return level; } set { level = value; } }
    public int Cost { get { return cost; } set { cost = value; } }
}
