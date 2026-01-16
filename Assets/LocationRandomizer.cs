using UnityEngine;

public class LocationRandomizer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector2(Random.Range(-9f, 9f), Random.Range(-3f, 3f));
        Debug.Log("here");
    }
}
