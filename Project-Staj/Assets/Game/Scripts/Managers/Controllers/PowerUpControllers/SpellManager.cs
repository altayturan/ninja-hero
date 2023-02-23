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

   

    //public void AddGold()
    //{
    //    GoldManager.Instance.ChangeGoldWithAmount(100);
    //}


}
