using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void StartRunning()
    {
        animator.SetBool("isRunning", true);
    }

    public void StopRunning()
    {
        animator.SetBool("isRunning", false);
    }
}
