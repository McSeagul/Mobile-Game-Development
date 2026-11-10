
using UnityEngine;

public class BouncePadLogic : MonoBehaviour
{
    public PlayerRules RigidbodyGrabber;

    public float playerVelocity; //using an extra float variable for readability. It grabs the velocity from playerrules and sets it as a variable. 
    

    void FixedUpdate()
    {
        playerVelocity = RigidbodyGrabber.linearVelY;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player") && playerVelocity <= 0f)
        {
            RigidbodyGrabber.ForceApplied();
        }
    }
}
