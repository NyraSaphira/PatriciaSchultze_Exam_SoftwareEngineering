using UnityEngine;

public class C_FireFinish : MonoBehaviour
{
    [SerializeField] private Color newColor;
    private SpriteRenderer _spriteRenderer;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Fire" && C_AlwaysThere.AllFireDias)
        {
            C_AlwaysThere.FireInFinish = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Fire") C_AlwaysThere.FireInFinish = false;
    }

    public void ChangeColor()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = newColor;
    }
}
