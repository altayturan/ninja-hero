using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTextUpdater : BoosterTextUpdater
{
    private void Start()
    {
        SetText();
    }
    public void SetText()
    {
        SetText("Lvl. " + powerUp.Level.ToString());
    }
}
