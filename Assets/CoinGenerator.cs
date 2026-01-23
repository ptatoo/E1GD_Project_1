using UnityEngine;
using UnityEngine.UIElements;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] GameObject m_coin;
    public Counter counter;
    public int maxPoints = 10;
    Vector3[] position1 =
    {
        new Vector3(-2f, -2, 0),
        new Vector3(5f, -2, 0),
        new Vector3(17.5f, 4, 0),
        new Vector3(25.5f, 13, 0),
        new Vector3(29.5f, 19, 0),
        new Vector3(35.5f, 13, 0),
        new Vector3(32.5f, 10f, 0),
        new Vector3(44.5f, 7f, 0),
        new Vector3(47.5f, 13, 0),
        new Vector3(59.5f, -8, 0),
    };

    public GameObject[] coins;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
            coins[i].gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
