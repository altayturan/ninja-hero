using UnityEngine;

public class TankPooler : Pooler<TankEnemy>
{
    public override void CreateNew()
    {
        base.CreateNew();
        temp.TankPooler = this;
    }
}
