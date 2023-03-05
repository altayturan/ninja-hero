using UnityEngine;

public class SpeedyPooler : Pooler<SpeedyEnemy>
{
    public override void CreateNew()
    {
        SpeedyEnemy newItem = Instantiate(prefab, pos, Quaternion.identity);
        PutToPool(newItem);
        newItem.SpeedyPooler = this;
    }
}
