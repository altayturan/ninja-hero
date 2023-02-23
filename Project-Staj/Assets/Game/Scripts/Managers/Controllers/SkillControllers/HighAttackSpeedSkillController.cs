using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighAttackSpeedSkillController : BaseSkillController
{
    [SerializeField] private PlayerData playerData;
    protected IEnumerator HighAttackSpeedCoolDown()
    {
        skillButton.interactable = false;
        float oldValue = playerData.FireInterval;
        playerData.FireInterval = 0.1f;
        yield return new WaitForSeconds(5);
        playerData.FireInterval = oldValue;
        yield return new WaitForSeconds(skill.Cooldown-5);
        skillButton.interactable = true;
    }

    public override void OnClickSkill()
    {
        base.OnClickSkill();
        base.StartCooldown(HighAttackSpeedCoolDown());
    }
}
