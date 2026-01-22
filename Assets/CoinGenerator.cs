using UnityEngine;
using UnityEngine.UIElements;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] GameObject m_coin;
    public Counter counter;
    public int maxPoints = 10;
    Vector3[] position1 =
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

    [SerializeField] detectPlayer[] pts;
    public GameObject[] coins;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resetLevel(0);
    }

    public void resetLevel(int lvl)
    {
        Vector3[] curPos = { };
        switch (lvl)
        {
            case 0:
                curPos = position1;
                break;
        }

        for (int i = 0; i < maxPoints; i++) {
            coins[i].gameObject.SetActive(true);
            coins[i].gameObject.transform.position = curPos[i];
        }
        for (int i = maxPoints; i < 10; i++)
        {
            coins[i].gameObject.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
