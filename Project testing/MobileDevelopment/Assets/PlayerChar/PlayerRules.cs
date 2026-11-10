using UnityEngine;

public class PlayerRules : MonoBehaviour
{
    private float xMin, xMax;
    float spriteSize;
    float xValid;
    public float linearVelY;
    public float padForceNum = 3f;


    public SpriteRenderer sprite;
    public Camera cam;
    public Rigidbody2D rb;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteSize = sprite.bounds.size.x * .5f;
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        xMin = -camWidth + spriteSize;
        xMax = camWidth - spriteSize;
    }

    // Update is called once per frame
    void Update()
    {
        xValid = Mathf.Clamp(transform.position.x, xMin, xMax);

        transform.position = new Vector2(xValid, transform.position.y);
    }
    void FixedUpdate()
    {
        linearVelY = rb.linearVelocity.y;
    }
    public void ForceApplied()
    {
        rb.AddForce(transform.up * padForceNum, ForceMode2D.Impulse);
    }
}
