using UnityEngine;
using UnityEngine.UIElements;

public class PlayerRules : MonoBehaviour
{
    private float xMin, xMax;
    private float yMin;
    float spriteSize;
    float spriteHeight; 
    float xValid;
    public float linearVelY;



    //References to bouncepad scripts to rewrite applied force (applied force float used to simplify writing across scripts.)
    public float forceApplied;



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
        //Camera size for player clamping
        spriteSize = sprite.bounds.size.x * .5f;
        spriteHeight = sprite.bounds.size.y * .5f;
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        //Calculates cam width and size of character to avoid clipping offscreen
        xMin = -camWidth + spriteSize;
        xMax = camWidth - spriteSize;

    }

    // Update is called once per frame
    void Update()
    {
        //Clamp left and right movement to camera bounds (camera scales to different screen sizes.)
        xValid = Mathf.Clamp(transform.position.x, xMin, xMax);

        transform.position = new Vector2(xValid, transform.position.y);
    }
    void FixedUpdate()
    {
        //Grab player velocity for bounce pad refernece.
        linearVelY = rb.linearVelocity.y; 

    }
    public void appliedForce()
    { 
        rb.AddForce(transform.up * forceApplied, ForceMode2D.Impulse);
    }
}
