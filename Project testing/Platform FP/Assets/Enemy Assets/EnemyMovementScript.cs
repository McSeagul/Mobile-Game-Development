using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class EnemyMovementScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public int fliptoggle;
    public bool flip;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("EnemyBound"))
        {
            fliptoggle = 1;
        }
        if(other.CompareTag("EnemyBoundInv"))
        {
            fliptoggle = 0;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(fliptoggle == 1)
        {
            flip = true;
        } else
        {
            flip = false;
        }
        if (flip == false)
        {
            enemyLeft();
        }
        else if (flip == true)
        {
            enemyRight();
        }
    }
    void enemyLeft()
    {
        rb.linearVelocityX = -moveSpeed;
        transform.localRotation = Quaternion.Euler(0, 0, 0);

    }
    void enemyRight()
    {
        rb.linearVelocityX = moveSpeed;
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    }
}
