using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Cinemachine.DocumentationSortingAttribute;

public class BasePowerUpButtonController : MonoBehaviour
{
    [SerializeField] private Resource gold;
    [SerializeField] internal PowerUp powerUp;
    [SerializeField] internal PlayerData playerData;

    [SerializeField] private TMP_Text levelText;
    private Button powerUpButton;

    private void Start()
    {
        powerUpButton = GetComponent<Button>();
        levelText.text = "Lvl. " + powerUp.Level.ToString();
    }

    public virtual void OnClickPowerUp()
    {
        if (!gold.isEnough(powerUp.Cost)) return;
        powerUp.LevelUp();
        if (powerUp.Level + 1 > powerUp.MaxLevel) { powerUpButton.interactable = false; return; }
    }

    public void SetLevelText()
    {
        levelText.text = "Lvl. " + powerUp.Level.ToString();
    }
}
