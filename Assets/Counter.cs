using UnityEngine;
using UnityEngine.UIElements;

public class Counter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int point = 0;
    public pointIndicator pt1;
    public pointIndicator pt2;
    public pointIndicator pt3;
    public pointIndicator pt4;
    public pointIndicator pt5;
    public pointIndicator pt6;
    public pointIndicator pt7;
    public pointIndicator pt8;
    public pointIndicator pt9;
    public pointIndicator pt10;
    void Start()
    {
        
    }

    public void addPt()
    {
        point = point + 1;
        switch (point)
        {
            case (1):
                pt1.ChangeSprite();
                break;
            case (2):
                pt2.ChangeSprite();
                break;
            case (3):
                pt3.ChangeSprite();
                break;
            case (4):
                pt4.ChangeSprite();
                break;
            case (5):
                pt5.ChangeSprite();
                break;
            case (6):
                pt6.ChangeSprite();
                break;
            case (7):
                pt7.ChangeSprite();
                break;
            case (8):
                pt8.ChangeSprite();
                break;
            case (9):
                pt9.ChangeSprite();
                break;
            case (10):
                pt10.ChangeSprite();
                break;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
