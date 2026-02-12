using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class Counter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int point = 0;
    public int maxPoints = 10;
    public pointIndicator[] pts;
    public LvlController controller;
    void Start()
    {
    }

    public void resetCounter(int lvl)
    {
        point = 0;
        int count = 0;
        foreach (pointIndicator pt in pts)
        {
            pt.ResetSprite();
            count++;
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
        if (point >= maxPoints)
        {
            controller.gameWon();
        }
    }
}
