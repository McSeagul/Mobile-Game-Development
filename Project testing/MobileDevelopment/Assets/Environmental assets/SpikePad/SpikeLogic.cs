using UnityEngine;

public class SpikeLogic : MonoBehaviour
{
    [Header("Reference Player HP_Script")]
    public PlayerHP HPUpdate; //Changes values in playerHP


    private void OnCollisionEnter2D(Collision2D other) //searches for player contact
    {
        if(other.collider.CompareTag("Player")) //We dont need to check if player is falling here unlike the bouncepads
        {
            HPUpdate.hitPoints--;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.collider.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }

}
