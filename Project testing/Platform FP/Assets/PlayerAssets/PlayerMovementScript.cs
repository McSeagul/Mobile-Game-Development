using System;
using System.Collections;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;

public class PlayerMovementScript : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpForce = 15f;
    public float fallMultiplier = 2f;
    public float lowJump = 2f;
    Rigidbody2D rb;
    float xInput;
    public bool grounded = true;
    public bool doubleJump;
    Animator animator;
    SpriteRenderer playersprite;
    public float AtkTime = 0.9f;
    public bool flipX;
    public bool IsAttacking;

    //new- input system
    public InputActionAsset InputActions;

    private InputAction m_moveAction;
    private InputAction m_jumpAction;

    private Vector2 m_moveAmt;

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playersprite = GetComponent<SpriteRenderer>();
        m_moveAction = InputSystem.actions.FindAction("Move");
        m_jumpAction = InputSystem.actions.FindAction("Jump");
    }
    // Update is called once per frame
    void Update()
    {   
        m_moveAmt = m_moveAction.ReadValue<Vector2>();

        float xMovement = rb.linearVelocity.x;




        //Horizontal Movement (Doesnt work if stationary slash is active to avoid footsliding)
        if(animator.GetBool("moveSlash") != true)
        {
            xInput = Input.GetAxisRaw("Horizontal");
        } else if (animator.GetBool("moveSlash") == true)
        {
            xMovement = 0;
        }
            

        if (m_jumpAction.WasPressedThisFrame() && grounded == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

        }
        if (grounded == false)
        {
            if (m_jumpAction.WasPressedThisFrame() && doubleJump == true)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
                doubleJump = false;
            }
        }
        if (xMovement < 0)
        {
            playersprite.flipX = true;
            flipX = true;
        }
        else if (xMovement > 0)
        {
            playersprite.flipX = false;
            flipX = false;
        }
        else
        {

        }
        if (Input.GetButtonDown("Fire1") && animator.GetBool("IsJumping") == false && animator.GetBool("moveSlash") == false && xMovement == 0 && animator.GetBool("QSlash") == false)
        {
            animator.SetBool("moveSlash", true);
            AtkTime = 0.48f;
            IsAttacking = true;
            StartCoroutine(MoveSlashTime());
        }
        if (Input.GetButtonDown("Fire1") && xMovement != 0 && animator.GetBool("IsJumping") == false && animator.GetBool("moveSlash") == false && animator.GetBool("QSlash") == false)
        {
            animator.SetBool("QSlash", true);
            AtkTime = 0.31f;
            IsAttacking = true;
            StartCoroutine(QSlashTime());
        }
    }
    IEnumerator MoveSlashTime()
    {
        while(animator.GetBool("moveSlash") == true)
        {
            if(animator.GetBool("moveSlash") == true)
            {
                yield return new WaitForSeconds(AtkTime);
                animator.SetBool("moveSlash", false);
                IsAttacking = false;
                StopAllCoroutines();

            }
        }
        
    }
    IEnumerator QSlashTime()
    {
        while (animator.GetBool("QSlash") == true)
        {
            if (animator.GetBool("QSlash") == true)
            {
                yield return new WaitForSeconds(AtkTime);
                animator.SetBool("QSlash", false);
                IsAttacking = false;
                StopAllCoroutines();

            }
        }

    }
    private void FixedUpdate()
    {
        Walking();
            
        //rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
        animator.SetFloat("yVelocity", rb.linearVelocity.y);
    }
    private void Walking()
    {
        rb.linearVelocity = new Vector2(m_moveAmt.x * moveSpeed, rb.linearVelocityY);
    }
}
