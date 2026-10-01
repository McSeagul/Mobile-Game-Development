using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float bulletSpeed;
    public EnemyMovementScript Emove;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = transform.up * bulletSpeed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
        if(other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("GameOver");
        }

    }
}
