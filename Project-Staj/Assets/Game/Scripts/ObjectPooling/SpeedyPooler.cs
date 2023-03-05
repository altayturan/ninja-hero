using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedyPooler : Pooler<EnemyController>
{
    public override void CreateNew()
    {
        EnemyController newItem = Instantiate(prefab, pos, Quaternion.identity);
        PutToPool(newItem);
    }
}
