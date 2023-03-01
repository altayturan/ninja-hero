using System.Collections;
using TMPro;
using UnityEngine;

public class SkillCooldowner : BaseTextUpdater
{
    [SerializeField] private Skill skill;
    [SerializeField] private TMP_Text cooldownText;
    [SerializeField] private StateData stateData;

    private float tempCooldown;

    private void Start()
    {
    }
    public void ActivateCooldown()
    {
        tempCooldown = skill.Cooldown;
        cooldownText.enabled = true;
        StartCoroutine(ReduceCooldowner());
    }
    protected override string GetText()
    {
        return Mathf.FloorToInt(tempCooldown).ToString();
    }

    private IEnumerator ReduceCooldowner()
    {
        while (true)
        {
            if (tempCooldown > 0 && stateData.CurrentState == States.PLAY)
            {
                SetText();
                tempCooldown -= Time.deltaTime;
                yield return null;
                continue;
            }
            if (stateData.CurrentState == States.STOP)
            {
                StopCoroutine(ReduceCooldowner());
                yield break;
            }
            DeactivateCooldown(); 
        }
    }
    public void DeactivateCooldown()
    {
        Debug.Log("Deactivated");
        StopAllCoroutines();
        tempCooldown = skill.Cooldown;
        cooldownText.enabled = false;
    }
}
