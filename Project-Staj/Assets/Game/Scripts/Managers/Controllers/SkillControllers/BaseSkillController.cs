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
    [SerializeField] protected GameStatistics gameStatistics;

    private void OnEnable()
    {
        skillButton.onClick.AddListener(OnClickSkill);
    }
    private void OnDisable()
    {
        skillButton.onClick.RemoveListener(OnClickSkill);
    }
    public virtual void OnClickSkill()
    {
        if (!gold.isEnough(skill.Cost)) return;
        gameStatistics.TotalSpentGold += skill.Cost;
        skill.OnUsed.Invoke();
        StartCoroutine(Cooldown());
    }
    protected virtual IEnumerator Cooldown() 
    {
        skillButton.interactable = false;
        yield return new WaitForSeconds(skill.Cooldown);
        skillButton.interactable = true;
    }

    public void ResetSkill()
    {
        StopAllCoroutines();
        skillButton.interactable = true;
    }
}
