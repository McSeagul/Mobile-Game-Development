using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimator : MonoBehaviour
{
    public Animator animator;
    public InputActionAsset InputActions;
    private InputAction m_moveAction;
    private Vector2 mov;

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }
    private void Awake()
    {
        m_moveAction = InputSystem.actions.FindAction("Move");
    }
    void Update()
    {
        mov = m_moveAction.ReadValue<Vector2>();
        bool moving = mov.x != 0;
        animator.SetBool("IsWalking", moving);
    }
}
