using System.Collections;
using UnityEngine;

public class HighAttackSpeedSkillController : BaseSkillController
{
    [SerializeField] private PlayerData playerData;

    public override void OnClickSkill()
    {
        base.OnClickSkill();
        StartCoroutine(ApplySkill());
    }
    protected IEnumerator ApplySkill() 
    {
        float oldValue = playerData.FireInterval;
        playerData.FireInterval = 0.1f;
        yield return new WaitForSeconds(5);
        playerData.FireInterval = oldValue;
    }
}
