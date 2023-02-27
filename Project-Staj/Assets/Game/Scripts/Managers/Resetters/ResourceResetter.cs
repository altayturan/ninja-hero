using UnityEngine;

public class ResourceResetter : MonoBehaviour
{
    [SerializeField] private Resource gold;
    [SerializeField] private Resource time;

    public void ResetResources()
    {
        gold.Amount = gold.BaseAmount;
        time.Amount = time.BaseAmount;
    }
}
