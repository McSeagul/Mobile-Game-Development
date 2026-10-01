using UnityEngine;

public class AttackOther : MonoBehaviour
{
    public PlayerMovementScript Atk;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (Atk.flipX == false && Atk.IsAttacking == true)
            {
                Destroy(other.gameObject);
            }
            
        }
    }
}
