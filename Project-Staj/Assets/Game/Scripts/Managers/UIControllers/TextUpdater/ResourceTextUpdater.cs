using UnityEngine;

public class ResourceTextUpdater : BaseTextUpdater
{
    [SerializeField] internal Resource resource;

    protected override string GetText()
    {
        return resource.Amount.ToString();
    }
}
