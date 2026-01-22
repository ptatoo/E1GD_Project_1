using UnityEngine;
using UnityEngine.UIElements;

public class Counter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int point = 0;
    public int maxPoints = 10;
    public pointIndicator[] pts;
    void Start()
    {
        resetLevel(0);
    }

    public void resetLevel(int lvl)
    {
        point = 0;
        foreach (pointIndicator pt in pts)
        {
            pt.ResetSprite();
        }
    }

    public void addPt()
    {
        point = point + 1;
        pts[point - 1].ChangeSprite();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
