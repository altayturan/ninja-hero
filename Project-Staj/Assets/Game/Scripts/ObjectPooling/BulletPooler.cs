using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooler : Pooler<BulletController>
{
    public override void CreateNew()
    {
        BulletController newItem = Instantiate(prefab, pos, Quaternion.identity);
        PutToPool(newItem);
        newItem.BulletPooler = this;
    }

}
