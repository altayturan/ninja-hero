using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAllSkillController : BaseSkillController

{
    protected IEnumerator DamageAllCooldown()
    {
        skillButton.interactable = false;
        foreach (EnemyController ec in GameManager.Instance.enemyControllers)
        {
            ec.GetEnemyData().Health -= 100;
        }
        yield return new WaitForSeconds(skill.Cooldown);
        skillButton.interactable = true;
    }

    public override void OnClickSkill()
    {
        base.OnClickSkill();
        base.StartCooldown(DamageAllCooldown());
    }
}
