using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GametimeTextUpdater : ResourceTextUpdater
{
    protected override string GetText()
    {
        return Mathf.FloorToInt(resource.Amount / 60).ToString("00") + " : " + Mathf.FloorToInt(resource.Amount % 60).ToString("00");
    }
}
