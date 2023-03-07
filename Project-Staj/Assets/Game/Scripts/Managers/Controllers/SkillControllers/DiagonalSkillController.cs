using UnityEngine;

public class DiagonalSkillController : BaseSkillController
{
    [SerializeField] private PlayerData playerData;

    public override void OnClickSkill()
    {
        base.OnClickSkill();
    }

    protected override void ApplySkill()
    {
        playerData.BulletAmount += 2;
    }
}
