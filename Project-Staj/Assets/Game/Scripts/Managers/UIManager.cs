using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    #region Singleton
    private UIManager uiManager;
    private static UIManager _instance;

    public static UIManager Instance { get { return _instance; } }

    private void Awake()
    {

        if (_instance != null && _instance != this)  // SINGLETON
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        uiManager = new UIManager();
    }
    #endregion

    [SerializeField] private TMP_Text timeText;
    [SerializeField] private TMP_Text goldText;

    [SerializeField] private TMP_Text attackSpeedCostText;
    [SerializeField] private TMP_Text damageCostText;
    [SerializeField] private TMP_Text numberShotCostText;
    [SerializeField] private TMP_Text diagonalCostText;
    [SerializeField] private TMP_Text damageAllCostText;
    [SerializeField] private TMP_Text highAttackSpeedCostText;

    [SerializeField] private Slider healthBar;

    public GameObject WinScreen;
    public GameObject LoseScreen;
    public GameObject Hud;

    public TMP_Text attackSpeedLevelText;
    public TMP_Text damageLevelText;
    public TMP_Text numberShotLevelText;

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
        healthBar.maxValue = StatisticManager.Instance.playerHealth;
        healthBar.value = PlayerController.Instance.Health;
    }
}
