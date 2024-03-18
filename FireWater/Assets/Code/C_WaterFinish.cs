using UnityEngine.Events;
using UnityEngine;

public class C_WaterFinish : MonoBehaviour
{
    public UnityEvent onFinish;
    [SerializeField] private Color newColor;
    private SpriteRenderer _spriteRenderer;
    private bool _finished;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Water" && C_AlwaysThere.AllWaterDias)C_AlwaysThere.WaterInFinish = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Water") C_AlwaysThere.WaterInFinish = false;
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (C_AlwaysThere.WaterInFinish && C_AlwaysThere.FireInFinish && !_finished)
        {
            _finished = true;
            onFinish?.Invoke();
        }
    }
    

    public void ChangeColor()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = newColor;
    }
}
