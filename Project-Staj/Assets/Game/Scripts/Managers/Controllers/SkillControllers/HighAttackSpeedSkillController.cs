using UnityEngine;

public class HighAttackSpeedSkillController : BaseSkillController
{
    [SerializeField] private PlayerData playerData;
    private int effectTime=5;
    private float oldValue;
    public override void OnClickSkill()
    {
        base.OnClickSkill();
    }

    public void CheckEffectTime()
    {
        if (stateData.CurrentState != States.PLAY || !isCasted) return;
        if (effectTime > 0)
        {
            effectTime--;
            if (effectTime == 0)
            {
                CancelSkill();
            }
        }
    }

    private void CancelSkill()
    {
        effectTime = 5;
        playerData.FireInterval = oldValue;
    }

    protected override void ApplySkill()
    {
        oldValue = playerData.FireInterval;
        playerData.FireInterval = 0.1f;
    }
}
