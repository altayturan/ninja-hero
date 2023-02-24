using System.Collections;
using TMPro;
using UnityEngine;

public class SkillCooldowner : BaseTextUpdater
{
    [SerializeField] private Skill skill;
    [SerializeField] private TMP_Text cooldownText;
    private float tempCooldown;

    public void ActivateCooldown()
    {
        tempCooldown = skill.Cooldown;
        cooldownText.enabled = true;
        StartCoroutine(ReduceCountdowner());
    }
    protected override string GetText()
    {
        return tempCooldown.ToString();
    }

    public IEnumerator ReduceCountdowner()
    {
        SetText();
        tempCooldown--;
        if (tempCooldown < 0)
        {
            DeactivateCooldown();
        }
        yield return new WaitForSeconds(1);
        yield return ReduceCountdowner();
    }
    private void DeactivateCooldown()
    {
        StopAllCoroutines();
        tempCooldown = skill.Cooldown;
        cooldownText.enabled = false;
    }
}
