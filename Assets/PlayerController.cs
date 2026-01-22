using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float inputX;
    public float inputY;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float jump = 500.0f;
    private Rigidbody2D rb;
    public bool isGrounded;
    public int numJump = 0;
    public Counter counter;
    Vector3[] startPos =
    {
        new Vector3(0, 0, 0)
    };


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        resetPlayer(0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float movementDistanceX = movementX * speed * Time.deltaTime;
        //float movementDistanceY = movementY * speed * Time.deltaTime;
        //transform.position = new Vector2(transform.position.x + movementDistanceX, transform.position.y + movementDistanceY); 
        rb.linearVelocity = new Vector2(inputX * speed, rb.linearVelocityY);
        if (inputY > 0 && numJump == 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, 0);
            rb.AddForce(new Vector2(0, jump));
            numJump = 1;
        }
        else if (inputY == 0 && numJump == 1 && !isGrounded)
        {
            numJump = 2;
        }
        else if (inputY > 0 && numJump == 2 && !isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, 0);
            rb.AddForce(new Vector2(0, jump));
            numJump = 3;
        }
    }

    public void resetPlayer(int lvl)
    {
        rb.linearVelocity = Vector3.zero;
        rb.position = startPos[lvl];
    }

    //void OnMove(InputValue value)
    //{
    //    Vector2 v = value.Get<Vector2>();
    //    inputX = v.x;
    //    inputY = v.y;
    //}
}
