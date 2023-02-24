using System.Collections;
using UnityEngine;

public class DiagonalSkillController : BaseSkillController
{
    [SerializeField] private PlayerData playerData;

    private void Start()
    {
        skillButton.interactable = true;
    }
    public override void OnClickSkill()
    {
        base.OnClickSkill();
        playerData.DiagonalShot = true;
        skillButton.interactable = false;
    }

    protected override IEnumerator GetCooldown()
    {
        return DiagonalCooldowner();
    }

    private IEnumerator DiagonalCooldowner()
    {
        yield return new WaitForSeconds(skill.Cooldown);
    }

}
