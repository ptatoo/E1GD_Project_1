using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class frogMovement : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] float jump = 400.0f;

    private float inputX;
    private float inputY;
    private bool isGrounded;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sprite;

    Vector3[] startPos =
    {
        new Vector3(0, 0, 0)
    };

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        resetLevel(0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(inputX * speed, rb.linearVelocityY);
        //jump
        if (!Mathf.Approximately(inputY, 0f) && inputY > 0 && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, 0);
            rb.AddForce(new Vector2(0, jump));
        }
        //running animation
        if (!Mathf.Approximately(inputX, 0f))
        {
            animator.SetBool("isRunning", true);
            sprite.flipX = inputX < 0;
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
        if (!isGrounded)
        {
            if (rb.linearVelocityY > 0)
            {
                animator.SetBool("isJumping", true);
                animator.SetBool("isFalling", false);
            }
            else
            {
                animator.SetBool("isJumping", false);
                animator.SetBool("isFalling", true);
            }
        }
        else animator.SetBool("isFalling", false);

    }

    public void resetLevel(int lvl)
    {
        rb.linearVelocity = Vector3.zero;
        rb.position = startPos[lvl];
        rb.gravityScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }

    void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();
        inputX = v.x;
        inputY = v.y;
    }
}
