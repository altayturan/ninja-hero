using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public abstract class Pooler<T> : MonoBehaviour where T : MonoBehaviour
{
    protected Vector3 pos = new Vector3(200, 0, 200);
    protected Queue<T> availablePool = new Queue<T>();
    [SerializeField] protected T prefab;
    public void PutToPool(T item)
    {
        item.gameObject.SetActive(false);
        Debug.Log("PutToPool");
        availablePool.Enqueue(item);
    }

    public T GetFromPool()
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

    public abstract void CreateNew();
}
