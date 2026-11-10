using UnityEngine;

public class PlayerRules : MonoBehaviour
{
    private float xMin, xMax;
    float spriteSize;
    float xValid;


    public SpriteRenderer sprite;
    public Camera cam;
    public Rigidbody rb;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
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
}
