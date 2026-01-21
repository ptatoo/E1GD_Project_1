using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Rigidbody2D playerRb;
    [SerializeField] int zOffset = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float y = playerRb.position.y;
        if (y < -40) y = -40;
        transform.position = new Vector3(playerRb.position.x, y, zOffset);
    }
}
