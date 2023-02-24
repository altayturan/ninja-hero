using UnityEngine;

public class ResourceTextUpdater : BaseTextUpdater
{
    [SerializeField] internal Resource resource;
    private void Start()
    {
        SetText();
    }

    protected override string GetText()
    {
        return resource.Amount.ToString();
    }
}
