using UnityEngine;

public class pointIndicator : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Sprite newSprite;
    public int pt_num = 11;
    public Counter counter;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
    }
    public void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
