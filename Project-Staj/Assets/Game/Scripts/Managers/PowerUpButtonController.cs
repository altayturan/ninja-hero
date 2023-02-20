using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerUpButtonController : MonoBehaviour
{
    [SerializeField] private Resource gold;

    [SerializeField] private PowerUp powerUp;
    [SerializeField] private TMP_Text levelText;
    public void OnClickPowerUp()
    {
        //if (!gold.isEnough(powerUp.Cost)) return;
        powerUp.LevelUp();
        StatisticManager.Instance.fireInterval -= 0.1f;
    }

    public void SetLevelText()
    {
        Debug.Log("Girdi");
        levelText.text = "Lvl. " + powerUp.Level.ToString();
    }
}
