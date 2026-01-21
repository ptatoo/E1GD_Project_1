using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] GameObject m_coin;
    Vector3[] positions =
    {
        new Vector3(-3f, -3, 0),
        new Vector3(3f, -3, 0),
        new Vector3(15f, 3, 0),
        new Vector3(21f, 12, 0),
        new Vector3(24f, 18, 0),
        new Vector3(30f, 12, 0),
        new Vector3(27f, 9f, 0),
        new Vector3(39f, 6f, 0),
        new Vector3(42f, 12, 0),
        new Vector3(51f, -9, 0),
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Vector3 pos in positions)
        {
            GameObject clone = Instantiate(m_coin, pos, Quaternion.identity);
            clone.transform.SetParent(transform, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
