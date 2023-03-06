using System.Collections.Generic;
using UnityEngine;

public class Pooler<T> : MonoBehaviour where T : MonoBehaviour
{
    protected Vector3 pos = new Vector3(200, 0, 200);
    public Queue<T> availablePool = new Queue<T>();
    [SerializeField] protected T prefab;
    protected T temp;
    public void PutToPool(T item)
    {
        item.gameObject.SetActive(false);
        availablePool.Enqueue(item);
    }

    public virtual T GetFromPool()
    {
        if (!IsAny())
            CreateNew();
        var temp = availablePool.Dequeue();
        temp.gameObject.SetActive(true);
        return temp;
    }

    public bool IsAny()
    {
        return availablePool.Count > 0;
    }
    public virtual void CreateNew()
    {
        temp = Instantiate(prefab);
        PutToPool(temp);
    }
}
