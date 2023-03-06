using UnityEngine;

public class DiagonalSkillController : BaseSkillController
{
    [SerializeField] private PlayerData playerData;

    public override void OnClickSkill()
    {
        base.OnClickSkill();
        playerData.BulletAmount += 2;
    }

}
