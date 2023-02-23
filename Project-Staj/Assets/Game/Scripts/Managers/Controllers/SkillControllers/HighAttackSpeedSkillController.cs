using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighAttackSpeedSkillController : BaseSkillController
{
    [SerializeField] private PlayerData playerData;
    private IEnumerator HighAttackSpeedCoolDown()
    {
        float oldValue = playerData.FireInterval;
        playerData.FireInterval = 0.1f;
        yield return new WaitForSeconds(5);
        playerData.FireInterval = oldValue;
        yield return new WaitForSeconds(skill.Cooldown);
    }

    public override void OnClickSkill()
    {
        base.OnClickSkill();
        base.StartCooldown("HighAttackSpeedCooldown");
    }
}
