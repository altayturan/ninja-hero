using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Cinemachine.DocumentationSortingAttribute;

public class PowerUpButtonController : MonoBehaviour
{
    [SerializeField] private Resource gold;
    [SerializeField] private PowerUp powerUp;
    [SerializeField] private PlayerData playerData;

    [SerializeField] private TMP_Text levelText;
    private Button powerUpButton;

    private void Start()
    {
        powerUpButton = GetComponent<Button>();
    }

    public void OnClickPowerUp()
    {
        if (!gold.isEnough(powerUp.Cost)) return;
        if (powerUp.Level + 1 > powerUp.MaxLevel) { powerUpButton.interactable = false; return; }

        powerUp.LevelUp();
        playerData.FireInterval.Amount -= 0.1f;
    }

    public void SetLevelText()
    {
        levelText.text = "Lvl. " + powerUp.Level.ToString();
    }
}
