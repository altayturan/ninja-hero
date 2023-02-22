using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldTextUpdater : BoosterTextUpdater
{
    private void Start()
    {
        SetText();
    }
    public void SetText()
    {
        SetText(powerUp.Cost.ToString());
    }
}
