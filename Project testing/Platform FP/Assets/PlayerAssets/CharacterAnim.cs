using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        bool moving = Input.GetAxisRaw("Horizontal") != 0;
        animator.SetBool("IsWalking", moving);
    }
}
