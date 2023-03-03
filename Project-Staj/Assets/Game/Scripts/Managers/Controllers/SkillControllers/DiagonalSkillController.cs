using UnityEngine;

public class DiagonalSkillController : BaseSkillController
{
    [SerializeField] private PlayerData playerData;

    public override void OnClickSkill()
    {
        base.OnClickSkill();
        Debug.Log("OnClickSkill");
        playerData.BulletAmount += 2;
    }

}
