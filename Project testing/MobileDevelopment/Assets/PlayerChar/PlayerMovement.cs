using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float moveSpeed = 7f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void LeftMove()
    {
        rb.linearVelocityX = -moveSpeed;
    }
    public void RightMove() 
    {
        rb.linearVelocityX = moveSpeed;
    }
}
