using UnityEngine;

public class groundManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] groundLevels;

    void Start()
    {
        
    }

    public void resetGround(int lvl)
    {
        for (int i = 0; i < groundLevels.Length; i++)
        {
            if (i == lvl) groundLevels[i].gameObject.SetActive(true);
            else groundLevels[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
