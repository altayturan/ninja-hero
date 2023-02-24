using ninjahero.events;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseSkillController : MonoBehaviour
{
    [SerializeField] protected Skill skill;
    [SerializeField] private Resource gold;
    [SerializeField] private GameEvent OnGoldChange;
    [SerializeField] protected Button skillButton;
    public virtual void OnClickSkill()
    {
        if (!gold.isEnough(skill.Cost)) return;
        skill.OnUsed.Invoke();
        OnGoldChange.Invoke();
        StartCooldown(GetCooldown());
    }

    protected void StartCooldown(IEnumerator method)
    {
        StartCoroutine(method);
    }

    protected abstract IEnumerator GetCooldown();
}
