using UnityEngine;

public class CreateGround : MonoBehaviour
{
    [SerializeField] GameObject m_Ground;
    Vector3[] positions1 =
    {
        new Vector3(0, -4, 0),
        new Vector3(-3f, -4, 0),
        new Vector3(3f, -4, 0),
        new Vector3(6f, -4, 0),
        new Vector3(9f, -4, 0),
        new Vector3(12f, -1, 0),
        new Vector3(15f, 2, 0),
        new Vector3(12f, 5, 0),
        new Vector3(21f, 11, 0),
        new Vector3(24f, 11, 0),
        new Vector3(27f, 11, 0),
        new Vector3(24f, 17, 0),
        new Vector3(30f, 11, 0),
        new Vector3(27f, 8, 0),
        new Vector3(36f, 5, 0),
        new Vector3(36f, 11, 0),
        new Vector3(39f, 5, 0),
        new Vector3(42f, 11, 0),
        new Vector3(51f, -10, 0),
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    public void resetGround(int lvl)
    {
        Vector3[] curPos = { };
        switch (lvl) {
            case 0:
                curPos = positions1;
                break;
        }
        foreach (Vector3 pos in curPos)
        {
            GameObject clone = Instantiate(m_Ground, pos, Quaternion.identity);
            clone.transform.SetParent(transform, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
