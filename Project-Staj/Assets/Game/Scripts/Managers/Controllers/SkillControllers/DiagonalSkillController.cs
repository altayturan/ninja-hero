using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalSkillController : BaseSkillController
{
    [SerializeField] private PlayerData playerData;
    public override void OnClickSkill()
    {
        base.OnClickSkill();
        playerData.DiagonalShot = true;
        skillButton.interactable = false;
    }
}
