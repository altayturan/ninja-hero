using System.Collections;
using TMPro;
using UnityEngine;

public class SkillCooldowner : BaseTextUpdater
{
    [SerializeField] private Skill skill;
    [SerializeField] private TMP_Text cooldownText;
    [SerializeField] private StateData stateData;

    private float tempCooldown;
    public void ActivateCooldown()
    {
        cooldownText.enabled = true;
        StartCoroutine(ReduceCooldowner());
    }
    protected override string GetText()
    {
        return tempCooldown.ToString();
    }

    public IEnumerator ReduceCooldowner()
    {
        while (true)
        {
            tempCooldown = skill.Cooldown;
            if (tempCooldown > 0 && stateData.CurrentState == States.PLAY)
            {
                SetText();
                tempCooldown-=Time.fixedDeltaTime;
                yield return null;
            }
            if (stateData.CurrentState == States.STOP)
            {
                StopCoroutine(ReduceCooldowner());
            }
            DeactivateCooldown();
        }
    }
    public void DeactivateCooldown()
    {
        StopAllCoroutines();
        tempCooldown = skill.Cooldown;
        cooldownText.enabled = false;
    }
}
