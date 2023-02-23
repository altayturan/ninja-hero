using ninjahero.events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseSkillController : MonoBehaviour
{
    [SerializeField] protected Skill skill;
    [SerializeField] private Resource gold;
    [SerializeField] private GameEvent OnGoldChange;
    [SerializeField] private Button skillButton;
    public virtual void OnClickSkill()
    {
        if (!gold.isEnough(skill.Cost)) return;
        OnGoldChange.Invoke();
    }

    protected void StartCooldown(string methodName)
    {
        if (!gold.isEnough(skill.Cost)) return;
        skillButton.interactable = false;
        StartCoroutine(methodName);
        skillButton.interactable = true;
    }
}
