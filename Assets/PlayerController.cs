using UnityEngine;
using UnityEngine.InputSystem;

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

    public Counter counter;
    public LvlController controller;
    Vector3[] startPos =
    {
        new Vector3(0, 0, 0)
    };


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float movementDistanceX = movementX * speed * Time.deltaTime;
        //float movementDistanceY = movementY * speed * Time.deltaTime;
        //transform.position = new Vector2(transform.position.x + movementDistanceX, transform.position.y + movementDistanceY); 
        rb.linearVelocity = new Vector2(inputX * speed, rb.linearVelocityY);
        if (inputY > 0 && numJump == 0 && !stopPlayer)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, 0);
            rb.AddForce(new Vector2(0, jump));
            numJump = 1;
        }
        else if (inputY == 0 && numJump == 1 && !isGrounded && !stopPlayer)
        {
            numJump = 2;
        }
        else if (inputY > 0 && numJump == 2 && !isGrounded && !stopPlayer)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, 0);
            rb.AddForce(new Vector2(0, jump));
            numJump = 3;
        }
        if (rb.position.y < -50)
        {
            stopPlayer = true;
            rb.gravityScale = 0;
            rb.linearVelocity = new Vector2(0, 0);
            controller.gameLost();
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
