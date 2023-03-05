using UnityEngine;

public class TankPooler : Pooler<TankEnemy>
{
    public override void CreateNew()
    {
        TankEnemy newItem = Instantiate(prefab, pos, Quaternion.identity);
        PutToPool(newItem);
        newItem.TankPooler = this;
    }
}
