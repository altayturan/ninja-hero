using System.Collections;
using TMPro;
using UnityEngine;

public class SkillCooldowner : BaseTextUpdater
{
    [SerializeField] private Skill skill;
    [SerializeField] private TMP_Text cooldownText;
    [SerializeField] private StateData stateData;

    public void ActivateCooldown()
    {
        cooldownText.enabled = true;
    }
    protected override string GetText()
    {
        if (skill.Cooldown <= 0)
            DeactivateCooldown();
        return Mathf.FloorToInt(skill.Cooldown).ToString();
    }
    public void DeactivateCooldown()
    {
        cooldownText.enabled = false;
    }
}
