using UnityEngine;

public class ResourceResetter : MonoBehaviour
{
    [SerializeField] private Resource gold;
    [SerializeField] private Resource time;

    public void RestartResources()
    {
        gold.Amount = gold.BaseAmount;
        time.Amount = time.BaseAmount;
    }
}
