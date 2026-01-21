using UnityEngine;

public class rotatePlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerController controller;
    public Vector3 rotationAmount = new Vector3(0,0,300);
    public Rigidbody2D playerRb;
    void Start()
    {
        transform.position = new Vector3(playerRb.position.x, playerRb.position.y, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (controller.inputX > 0)
        {
            transform.Rotate(-1 * rotationAmount * Time.deltaTime);
        }
        if (controller.inputX < 0)
        {
            transform.Rotate(rotationAmount * Time.deltaTime);
        }
    }
}
