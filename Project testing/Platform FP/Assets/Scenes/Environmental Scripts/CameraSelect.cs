using UnityEngine;

public class CameraSelect : MonoBehaviour
{
     
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
        }
    }

}
