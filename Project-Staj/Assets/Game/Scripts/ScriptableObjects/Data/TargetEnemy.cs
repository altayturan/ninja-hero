using UnityEngine;

[CreateAssetMenu(fileName ="TargetEnemy", menuName ="Game/Create Target Enemy")]
public class TargetEnemy : ScriptableObject
{
    private Transform target;

    public Transform Target
    {
        set { target = value; }
    }

    public bool GetTarget(out Transform _target)
    {
        if (target == null)
        {
            _target = null;
            return false;
        }

        _target = target;
        return true;

    }
}
