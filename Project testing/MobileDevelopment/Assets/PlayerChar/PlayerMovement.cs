using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    float moveSpeed = 7f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void LeftMove()
    {
        
    }
    public void RightMove() 
    {

    }
}
