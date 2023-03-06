using UnityEngine;

public class BulletPooler : Pooler<BulletController>
{
    public override BulletController GetFromPool()
    {
        return base.GetFromPool();
    }
    int counter;
    public override void CreateNew()
    {
        base.CreateNew();
        temp.BulletPooler = this;
    }

}
