using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void PlayAnimation()
    {
        animator.SetBool("isRunning", true);

    }

    public void StopAnimation()
    {
        animator.SetBool("isRunning", false);
    }
}
