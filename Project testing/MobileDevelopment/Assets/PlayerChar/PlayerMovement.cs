using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem.EnhancedTouch;
using TMPro;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float moveSpeed = 4f;
    float width;
    float height;
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
        int leftTouches = 0;
        int rightTouches = 0;
        foreach (Touch touch in Touch.activeTouches) 
        {
            Vector2 pos = touch.screenPosition;
            /*pos.x = (pos.x - width) / width;
            pos.y = (pos.y - height) / height;*/
            Debug.Log("Touch X: " + pos.x);
            Debug.Log("Touch Y: " + pos.y);
            if (pos.x < width)
            {
                leftTouches++;
            }
            else
            {
                rightTouches++;
            }
        }

        if (leftTouches > 0 && rightTouches == 0)
        {
            rb.linearVelocityX = -moveSpeed;
        }
        else if (rightTouches > 0 && leftTouches == 0)
        {
            rb.linearVelocityX = moveSpeed;
        }
        else 
        {
            rb.linearVelocityX = 0f;
        }

        //OlD INPUT SYSTEM CODE

        /*if(Input.touchCount > 0)
        {
            UnityEngine.Touch touch = Input.GetTouch(0);

            Vector2 pos = touch.position;
            pos.x = (pos.x - width) / width;
            pos.y = (pos.y - height) / height;
            Debug.Log("Touch X: " + pos.x);
            Debug.Log("Touch Y: " + pos.y);
        }*/

    }
}
