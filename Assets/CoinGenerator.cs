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
    Vector3[] position2 =
    {
        new Vector3(-3f, -4, 0),
        new Vector3(10f, -7, 0),
        new Vector3(31.5f, -7, 0),
        new Vector3(-3f, -9, 0),
        new Vector3(1.5f, -14, 0),
        new Vector3(-2.5f, -17, 0),
        new Vector3(9.5f, -18f, 0),
        new Vector3(17.5f, -20f, 0),
        new Vector3(-7.5f, -24, 0),
        new Vector3(-15.5f, -18, 0),
    };
    Vector3[] position3 =
    {
        new Vector3(3.5f, 1, 0),
        new Vector3(0f, 9, 0),
        new Vector3(5.5f, 17, 0),
        new Vector3(-0.5f, 23, 0),
        new Vector3(-11.5f, 26, 0),
        new Vector3(-27.5f, 18, 0),
        new Vector3(-37.5f, 5f, 0),
        new Vector3(-42f, 27f, 0),
        new Vector3(-51f, 19, 0),
        new Vector3(-60f, 31, 0),
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
            case 1:
                curPos = position2;
                break;
            case 2:
                curPos = position3;
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
