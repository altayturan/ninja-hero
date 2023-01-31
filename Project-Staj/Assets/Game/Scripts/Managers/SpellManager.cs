using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellManager : MonoBehaviour
{
    [SerializeField] private int attackSpeedLevel = 0;
    [SerializeField] private int damageLevel = 0;
    [SerializeField] private int numberShotLevel = 0;
    [SerializeField] private float damageAmount = 100f;
    public float damageAllCooldownTime = 15f;
    public float highAttackSpeedCooldownTime = 15f;

    [SerializeField] private GameObject attackSpeedButton;
    [SerializeField] private GameObject damageButton;
    [SerializeField] private GameObject numberShotButton;
    [SerializeField] private GameObject diagonalButton;
    [SerializeField] private GameObject damageAllButton;
    [SerializeField] private GameObject highAttackSpeedButton;

    public bool damageAllCasted = false;
    public bool highAttackSpeedCasted = false;


    private void Start()
    {
        UIManager.Instance.attackSpeedLevelText.text = "Lvl. " + attackSpeedLevel.ToString();
        UIManager.Instance.damageLevelText.text = "Lvl. " + damageLevel.ToString();
        UIManager.Instance.numberShotLevelText.text = "Lvl. " + numberShotLevel.ToString();
    }
    public void LevelUpAttackSpeed()
    {
        if (GoldManager.Instance.GetGold() < GoldManager.Instance.attackSpeedCost) return;
        
        attackSpeedLevel++;
        if (attackSpeedLevel + 1 > 11) { attackSpeedButton.GetComponent<Button>().interactable = false; }

        GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.attackSpeedCost);
        UIManager.Instance.attackSpeedLevelText.text = "Lvl. " + attackSpeedLevel.ToString();
        StatisticManager.Instance.fireInterval -= 0.1f;
    }

    public void LevelUpDamage()
    {

        if (GoldManager.Instance.GetGold() < GoldManager.Instance.damageCost) return;
        
        damageLevel++;
        if (damageLevel + 1 > 42) { damageButton.GetComponent<Button>().interactable = false; }
        
        GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.damageCost);
        UIManager.Instance.damageLevelText.text = "Lvl. " + damageLevel.ToString();
        StatisticManager.Instance.bulletDamage *= 1.1f;
    }

    public void LevelUpNumberShot()
    {
        if (GoldManager.Instance.GetGold() < GoldManager.Instance.numberShotCost) return;
        
        numberShotLevel++;
        if (numberShotLevel + 1 > 3) { numberShotButton.GetComponent<Button>().interactable = false; }

        GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.numberShotCost);
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
        damageAllCasted = true;
        foreach (EnemyController ec in GameManager.Instance.enemyControllers)
        {
            ec.ChangeHealthWithAmount(-damageAmount);
        }
        yield return new WaitForSeconds(damageAllCooldownTime);
        damageAllButton.GetComponent<Button>().interactable = true;
        damageAllCasted = false;
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
        highAttackSpeedCasted = true;
        float oldValue = StatisticManager.Instance.fireInterval;
        StatisticManager.Instance.fireInterval = 0.1f;
        yield return new WaitForSeconds(5);
        StatisticManager.Instance.fireInterval = oldValue;
        yield return new WaitForSeconds(highAttackSpeedCooldownTime);
        highAttackSpeedButton.GetComponent<Button>().interactable = true;
        highAttackSpeedCasted = false;
    }

    public void StartHighAttackSpeedCountDown()
    {
        if (GoldManager.Instance.GetGold() < GoldManager.Instance.highAttackSpeedCost) return;

        GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.highAttackSpeedCost);
        StartCoroutine(HighAttackSpeedCountDown());
    }

    public void AddGold()
    {
        GoldManager.Instance.ChangeGoldWithAmount(100);
    }


}
