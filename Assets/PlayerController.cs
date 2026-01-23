using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.U2D;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float inputX;
    public float inputY;
    public bool isGrounded;
    public int numJump = 0;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float jump = 500.0f;

    private Rigidbody2D rb;
    private bool stopPlayer = false;
    private Animator animator;
    private SpriteRenderer sprite;

    public Counter counter;
    public LvlController controller;
    public GameObject playerCostume;
    Vector3[] startPos =
    {
        new Vector3(0, 0, 0)
    };


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = playerCostume.gameObject.GetComponent<Animator>();
        sprite = playerCostume.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //x velocity
        rb.linearVelocity = new Vector2(inputX * speed, rb.linearVelocityY);
        if (!Mathf.Approximately(inputX, 0f))
        {
            animator.SetBool("running", true);
            sprite.flipX = inputX < 0;
        }
        else animator.SetBool("running", false);

        //first jump
        if (inputY > 0 && numJump == 0 && !stopPlayer)
        {
            animator.SetBool("jumping", true);
            rb.linearVelocity = new Vector2(rb.linearVelocityX, 0);
            rb.AddForce(new Vector2(0, jump));
            numJump = 1;
        }

        //not jumping; can do a second one
        else if (inputY == 0 && numJump == 1 && !isGrounded && !stopPlayer)
        {
            numJump = 2;
        }

        //second jump
        else if (inputY > 0 && numJump == 2 && !isGrounded && !stopPlayer)
        {
            animator.SetTrigger("doubleJump");
            rb.linearVelocity = new Vector2(rb.linearVelocityX, 0);
            rb.AddForce(new Vector2(0, jump));
            numJump = 3;
        }

        //falling out into the void
        if (rb.position.y < -50)
        {
            stopPlayer = true;
            rb.gravityScale = 0;
            rb.linearVelocity = new Vector2(0, 0);
            controller.gameLost();
        }

        //grounded animation
        if (isGrounded)
        {
            animator.SetBool("grounded", true);
            animator.SetBool("jumping", false);
            animator.ResetTrigger("doubleJump");
        }
        else
        {
            animator.SetBool("grounded", false);
            animator.SetBool("jumping", true);
        }
    }

    public void resetLevel(int lvl)
    {
        rb.linearVelocity = Vector3.zero;
        rb.position = startPos[lvl];
        stopPlayer = false;
        rb.gravityScale = 1;
    }
}
