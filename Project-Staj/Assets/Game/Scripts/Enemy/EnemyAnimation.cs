using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void StartRunning()
    {
        animator.speed = 2f;
    }

    public void StopRunning()
    {
        animator.speed = 0f;
    }
}
