using ninjahero.events;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseSkillController : MonoBehaviour
{
    [SerializeField] protected Skill skill;
    [SerializeField] private Resource gold;
    [SerializeField] private GameEvent OnGoldChange;
    [SerializeField] protected Button skillButton;
    [SerializeField] protected GameStatistics gameStatistics;
    [SerializeField] protected StateData stateData;
    protected bool isCasted = false;

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
        isCasted = true;
        skillButton.interactable = false;
    }

    public void CheckSkillCooldown()
    {
        if (stateData.CurrentState != States.PLAY
            || !isCasted) return;
        if (skill.Cooldown > 0)
        {
            skill.Cooldown--;
            if (skill.Cooldown == 0)
            {
                ResetSkill();
                skill.Cooldown = skill.BaseCooldown;
            }
        }
    }

    public void ResetSkill()
    {
        skillButton.interactable = true;
        isCasted = false;
    }
}
