using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellManager : MonoBehaviour
{
    [SerializeField] private int attackSpeedLevel = 1;
    [SerializeField] private int damageLevel = 1;
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
    public void LevelUpAttackSpeed()
    {
        if (attackSpeedLevel >= 11) return;
        
        attackSpeedLevel++;
        StatisticManager.Instance.fireInterval -= 0.1f;
    }

    public void LevelUpDamage()
    {
        if (damageLevel >= 42) return;

        damageLevel++;
        StatisticManager.Instance.bulletDamage *= 1.1f;
    }

    public void LevelUpNumberShot()
    {
        if (numberShotLevel >= 3) return;

        numberShotLevel++;
        StatisticManager.Instance.numberOfShots += 1;
    }

    public void AddDiagonalShot()
    {
        StatisticManager.Instance.diagonalShot = true;
        diagonalButton.GetComponent<Button>().interactable = false;
    }

    private IEnumerator DamageAllCountdown()
    {
        foreach(EnemyController ec in GameManager.Instance.enemyControllers)
        {
            ec.ChangeHealthWithAmount(-damageAmount);
        }
        
        damageAllButton.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(damageAllCountdownTime);
        damageAllButton.GetComponent<Button>().interactable = true;
    }

    public void StartDamageAllCountdown()
    {
        StartCoroutine(DamageAllCountdown());
    }

    private IEnumerator HighAttackSpeedCountDown()
    {
        float oldValue = StatisticManager.Instance.fireInterval;
        StatisticManager.Instance.fireInterval = 0.1f;
        highAttackSpeedButton.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(HighAttackSpeedCountdownTime);
        StatisticManager.Instance.fireInterval = oldValue;
        highAttackSpeedButton.GetComponent<Button>().interactable = true;
    }

    public void StartHighAttackSpeedCountDown()
    {
        StartCoroutine(HighAttackSpeedCountDown());
    }




}
