using UnityEngine;

public class GametimeTextUpdater : ResourceTextUpdater
{
    protected override string GetText()
    {
        var minute = Mathf.FloorToInt(resource.Amount / 60).ToString("00");
        var seconds = Mathf.FloorToInt(resource.Amount % 60).ToString("00");
        var text = $"{minute} : {seconds}";
        return text;
    }
}
