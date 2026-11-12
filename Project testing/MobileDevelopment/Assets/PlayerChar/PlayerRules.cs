using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerRules : MonoBehaviour
{
    private float xMin, xMax;
    float spriteSize;
    float spriteHeight;
    float xValid; //Calculations to camera limits and sprite bounds


    [Header("Reference to Pad")]
    //References to bouncepad scripts to rewrite applied force (applied force float used to simplify writing across scripts.)
    public float forceApplied;
    public float linearVelY;


    [Header("General Data")]
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

        //Uses RB and is gravity scale dependant hence why it is in fixed update. 
        Vector2 correctedPlayerPosY = new Vector2(transform.position.x, transform.position.y + spriteHeight); //Creates transform pos account for player height.
        Vector3 pos = cam.WorldToViewportPoint(correctedPlayerPosY); //Corrected transform input into the viewport point, which then calculates whether or not the player is now completely offscreen.
        if (pos.y < 0.0)
        {
            Debug.Log("PlayerLeftGameScope");
            //Reference endstatelevel in PlayerHP script

            Time.timeScale = 0f; //TempTestCode out of player scope.
        }
    }
    public void appliedForce()
    { 
        rb.AddForce(transform.up * forceApplied, ForceMode2D.Impulse); //Referenced through bouncepad scripts
    }
}
