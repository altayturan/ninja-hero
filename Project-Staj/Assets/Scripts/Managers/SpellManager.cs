using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellManager : MonoBehaviour
{
    [SerializeField] private int attackSpeedLevel = 0;
    [SerializeField] private int damageLevel = 0;
    [SerializeField] private int numberShotLevel = 0;
    [SerializeField] private float damageAllCountdownTime = 15f;
    [SerializeField] private float damageAmount = 100f;
    [SerializeField] private float HighAttackSpeedCountdownTime = 15f;

    [SerializeField] private GameObject attackSpeedButton;
    [SerializeField] private GameObject damageButton;
    [SerializeField] private GameObject numberShotButton;
    [SerializeField] private GameObject diagonalButton;
    [SerializeField] private GameObject damageAllButton;
    [SerializeField] private GameObject highAttackSpeedButton;

    private void Start()
    {
        UIManager.Instance.attackSpeedLevelText.text = "Lvl. " + attackSpeedLevel.ToString();
        UIManager.Instance.damageLevelText.text = "Lvl. " + damageLevel.ToString();
        UIManager.Instance.numberShotLevelText.text = "Lvl. " + numberShotLevel.ToString();
    }
    public void LevelUpAttackSpeed()
    {
        if (attackSpeedLevel >= 11) { attackSpeedButton.GetComponent<Button>().interactable = false; return; }
        if (GoldManager.Instance.GetGold() < GoldManager.Instance.attackSpeedCost) return;

        GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.attackSpeedCost);
        attackSpeedLevel++;
        UIManager.Instance.attackSpeedLevelText.text = "Lvl. " + attackSpeedLevel.ToString();
        StatisticManager.Instance.fireInterval -= 0.1f;
    }

    public void LevelUpDamage()
    {
        if (damageLevel >= 42) { damageButton.GetComponent<Button>().interactable = false; return; }
        if (GoldManager.Instance.GetGold() < GoldManager.Instance.damageCost) return;

        GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.damageCost);
        damageLevel++;
        UIManager.Instance.damageLevelText.text = "Lvl. " + damageLevel.ToString();
        StatisticManager.Instance.bulletDamage *= 1.1f;
    }

    public void LevelUpNumberShot()
    {
        if (numberShotLevel >= 3) { numberShotButton.GetComponent<Button>().interactable = false; return; }
        if (GoldManager.Instance.GetGold() < GoldManager.Instance.numberShotCost) return;

        GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.numberShotCost);
        numberShotLevel++;
        UIManager.Instance.numberShotLevelText.text = "Lvl. " + numberShotLevel.ToString();
        StatisticManager.Instance.numberOfShots += 1;
    }

    public void AddDiagonalShot()
    {
        if (GoldManager.Instance.GetGold() < GoldManager.Instance.diagonalShotCost) return;

        GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.diagonalShotCost);
        StatisticManager.Instance.diagonalShot = true;
        diagonalButton.GetComponent<Button>().interactable = false;
    }

    private IEnumerator DamageAllCountdown()
    {
        damageAllButton.GetComponent<Button>().interactable = false;
        foreach (EnemyController ec in GameManager.Instance.enemyControllers)
        {
            ec.ChangeHealthWithAmount(-damageAmount);
        }
        yield return new WaitForSeconds(damageAllCountdownTime);
        damageAllButton.GetComponent<Button>().interactable = true;
    }

    public void StartDamageAllCountdown()
    {
        if (GoldManager.Instance.GetGold() < GoldManager.Instance.damageAllCost) return;

        GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.damageAllCost);
        StartCoroutine(DamageAllCountdown());
    }

    private IEnumerator HighAttackSpeedCountDown()
    {
        highAttackSpeedButton.GetComponent<Button>().interactable = false;
        float oldValue = StatisticManager.Instance.fireInterval;
        StatisticManager.Instance.fireInterval = 0.1f;
        yield return new WaitForSeconds(HighAttackSpeedCountdownTime);
        StatisticManager.Instance.fireInterval = oldValue;
        highAttackSpeedButton.GetComponent<Button>().interactable = true;
    }

    public void StartHighAttackSpeedCountDown()
    {
        if (GoldManager.Instance.GetGold() < GoldManager.Instance.highAttackSpeedCost) return;

        GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.highAttackSpeedCost);
        StartCoroutine(HighAttackSpeedCountDown());
    }




}
