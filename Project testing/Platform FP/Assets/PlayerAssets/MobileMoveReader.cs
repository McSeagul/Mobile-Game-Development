// In a script with an InputActionReference assigned in the Inspector:
using UnityEngine;
using UnityEngine.InputSystem;

public class MobileMoveReader : MonoBehaviour
{
    [SerializeField] InputActionReference moveAction;

    void OnEnable() => moveAction.action.Enable();
    void OnDisable() => moveAction.action.Disable();

    void Update()
    {
        Vector2 move = moveAction.action.ReadValue<Vector2>();
        // Pass move to the movement code you already have.
    }
}