using UnityEngine;

public class AttackRules : MonoBehaviour
{
    public PlayerMovementScript Atk;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (Atk.flipX == true && Atk.IsAttacking == true)
            {
                Destroy(other.gameObject);
            } else
            {

            }

        }
    }
}
