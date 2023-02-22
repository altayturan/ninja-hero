using UnityEngine;

public class SpellManager : MonoBehaviour
{
    
    //public void AddDiagonalShot()
    //{
    //    if (GoldManager.Instance.GetGold() < GoldManager.Instance.diagonalShotCost) return;


    //    GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.diagonalShotCost);
    //    StatisticManager.Instance.diagonalShot = true;
    //    diagonalButton.GetComponent<Button>().interactable = false;
    //}

    //private IEnumerator DamageAllCountdown()
    //{
    //    damageAllButton.GetComponent<Button>().interactable = false;
    //    damageAllCasted = true;
    //    foreach (EnemyController ec in GameManager.Instance.enemyControllers)
    //    {
    //        ec.ChangeHealthWithAmount(-damageAmount);
    //    }
    //    yield return new WaitForSeconds(damageAllCooldownTime);
    //    damageAllButton.GetComponent<Button>().interactable = true;
    //    damageAllCasted = false;
    //}

    //public void StartDamageAllCountdown()
    //{
    //    if (GoldManager.Instance.GetGold() < GoldManager.Instance.damageAllCost) return;

    //    GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.damageAllCost);
    //    StartCoroutine(DamageAllCountdown());
    //}

    //private IEnumerator HighAttackSpeedCountDown()
    //{
    //    highAttackSpeedButton.GetComponent<Button>().interactable = false;
    //    highAttackSpeedCasted = true;
    //    float oldValue = StatisticManager.Instance.fireInterval;
    //    StatisticManager.Instance.fireInterval = 0.1f;
    //    yield return new WaitForSeconds(5);
    //    StatisticManager.Instance.fireInterval = oldValue;
    //    yield return new WaitForSeconds(highAttackSpeedCooldownTime);
    //    highAttackSpeedButton.GetComponent<Button>().interactable = true;
    //    highAttackSpeedCasted = false;
    //}

    //public void StartHighAttackSpeedCountDown()
    //{
    //    if (GoldManager.Instance.GetGold() < GoldManager.Instance.highAttackSpeedCost) return;

    //    GoldManager.Instance.ChangeGoldWithAmount(-GoldManager.Instance.highAttackSpeedCost);
    //    StartCoroutine(HighAttackSpeedCountDown());
    //}

    //public void AddGold()
    //{
    //    GoldManager.Instance.ChangeGoldWithAmount(100);
    //}


}
