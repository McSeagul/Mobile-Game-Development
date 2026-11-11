
using UnityEngine;

public class BouncePadLogic : MonoBehaviour
{
    public PlayerRules RigidbodyGrabber; //Player rb input
    public float bounceforce = 6f;

    public float playerVelocity; //using an extra float variable for readability. It grabs the velocity from playerrules and sets it as a variable. 
    

    void FixedUpdate()
    {
        //sets player velocity to new float for naming convenience
        playerVelocity = RigidbodyGrabber.linearVelY;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //checks collision with player and determines whether or not player is falling.
        if (other.collider.CompareTag("Player") && playerVelocity <= 0f) 
        {
            RigidbodyGrabber.forceApplied = bounceforce; //Apply changes to force impulse before calling the function.
            RigidbodyGrabber.appliedForce();
        }
    }
}
