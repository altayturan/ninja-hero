using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResetter : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    private float defaultSpeed;
    private float defaultHealth;
    private float defaultFireInterval;
    private int defaultNumbeOfShots;
    private float defaultRange;
    private bool defaultDiagonalShot;
    private void Start()
    {
        defaultSpeed = playerData.Speed;
        defaultHealth = playerData.Health;
        defaultFireInterval = playerData.FireInterval;
        defaultNumbeOfShots = playerData.NumberOfShots;
        defaultRange = playerData.Range;
        defaultDiagonalShot = playerData.DiagonalShot;
    }

    public void ResetPlayer()
    {
        playerData.Health = defaultHealth;
        playerData.Speed = defaultSpeed;
        playerData.Range = defaultRange;
        playerData.DiagonalShot = defaultDiagonalShot;
        playerData.FireInterval = defaultFireInterval;
        playerData.NumberOfShots = defaultNumbeOfShots;
    }
}
