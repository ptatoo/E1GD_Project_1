using UnityEngine;

public class pointIndicator : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Sprite newSprite;
    public Sprite oldSprite;
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

    public void ResetSprite()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = oldSprite;
        }
    }
}
