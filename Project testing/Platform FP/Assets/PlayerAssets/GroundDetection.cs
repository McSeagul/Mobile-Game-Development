using UnityEngine;

public class GroundDetection : MonoBehaviour
{
    public PlayerMovementScript Player;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            Player.grounded = true;
            Player.doubleJump = false;
            animator.SetBool("IsJumping", false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            Player.grounded = false;
            Player.doubleJump = true;
            animator.SetBool("IsJumping", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
