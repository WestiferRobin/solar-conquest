using UnityEngine;

public class PrismMouse : MonoBehaviour
{
    public Color highlightColor = Color.magenta;
    public Color pressedColor = Color.red;

    private Color originalColor;
    private SpriteRenderer spriteRenderer;
    private bool debugFlag = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (debugFlag)
            {
                spriteRenderer.color = highlightColor;
            }
            else
            {
                spriteRenderer.color = pressedColor;
            }
            debugFlag = !debugFlag;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // Restore the original color when the left mouse button is released
            spriteRenderer.color = debugFlag ? highlightColor : originalColor;
        }
    }

    void OnCollisionStay2D(Collision2D collision) => Debug.Log(collision);

    private void OnMouseEnter()
    {
        Debug.Log("ASDFASDF");
    }

    void OnMouseExit()
    {
        // Restore the original color when the mouse exits the object
        spriteRenderer.color = originalColor;
    }
}
