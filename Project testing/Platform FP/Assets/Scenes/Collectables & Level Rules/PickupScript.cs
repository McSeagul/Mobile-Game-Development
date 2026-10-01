using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public CollectableSystem CollectableSystem;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CollectableSystem.score += 1;
            Destroy(this.gameObject);
        }
    }
}
