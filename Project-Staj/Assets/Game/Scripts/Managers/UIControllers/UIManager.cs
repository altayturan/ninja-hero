using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    [SerializeField] private PowerUp attackSpeedPowerUp;
    [SerializeField] private PowerUp damagePowerUp;
    [SerializeField] private PowerUp numberOfShotsPowerUp;

    

    private void Update()
    {
        //if (GameManager.Instance.gameTime > 0)
        //    timeText.text = (Mathf.FloorToInt(GameManager.Instance.gameTime / 60)).ToString("00") + ":" + (Mathf.FloorToInt(GameManager.Instance.gameTime % 60)).ToString("00");

        //goldText.text = GoldManager.Instance.GetGold().ToString();

        //attackSpeedCostText.text = GoldManager.Instance.attackSpeedCost.ToString();
        //damageCostText.text = GoldManager.Instance.damageCost.ToString();
        //numberShotCostText.text = GoldManager.Instance.numberShotCost.ToString();
        //diagonalCostText.text = GoldManager.Instance.diagonalShotCost.ToString();
        //damageAllCostText.text = GoldManager.Instance.damageAllCost.ToString();
        //highAttackSpeedCostText.text = GoldManager.Instance.highAttackSpeedCost.ToString();

        UpdateHealthBar();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    private void UpdateHealthBar()
    {
        //uiData.HealthBar.maxValue = playerData.MaxHealth;
        //uiData.HealthBar.value = playerData.Health;
    }
}
