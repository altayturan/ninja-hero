using System.Collections;
using UnityEngine;

public class DamageAllSkillController : BaseSkillController
{
    protected IEnumerator DamageAllCooldown()
    {
        skillButton.interactable = false;
        yield return new WaitForSeconds(skill.Cooldown);
        skillButton.interactable = true;
    }

    protected override IEnumerator GetCooldown()
    {
        return DamageAllCooldown();
    }
}
