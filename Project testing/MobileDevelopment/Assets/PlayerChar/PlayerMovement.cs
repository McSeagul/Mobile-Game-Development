using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem.EnhancedTouch;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float moveSpeed = 7f;
    float width; 
    float height;
    UnityEngine.Touch touch;
    public TMP_Text text;

    void OnEnable()
    {
        TouchSimulation.Enable();
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        width = (float)Screen.width / 2f;
        height = (float)Screen.height / 2f;
        
    }
    void Start()
    {
        Debug.Log("Screen Width: " + Screen.width);
    }
    void Update()
    {
        if(Input.touchCount > 0)
        {
            UnityEngine.Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                pos.y = (pos.y - height) / height;
                Debug.Log("Touch X: " + pos.x);
                Debug.Log("Touch Y: " + pos.y);
            }
        }
    
    }
}
