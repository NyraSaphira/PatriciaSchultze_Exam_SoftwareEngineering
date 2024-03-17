using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class C_TK_Playing : MonoBehaviour
{
    private Label _txtFireCounter;
    private Label _txtWaterCounter;

    private int _waterDiamondsMax;
    private int _fireDiamondsMax;
    
    private int _waterDiamondsCurrent;
    private int _fireDiamondsCurrent;
    
    
public UnityEvent onWaterDiasCollected;
public UnityEvent onFireDiasCollected;
    void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        _txtFireCounter = root.Q<Label>("txt_fireCount");
        _txtWaterCounter = root.Q<Label>("txt_waterCount");
            
        _waterDiamondsMax = GameObject.FindGameObjectsWithTag("waterDiamond").Length;
        _fireDiamondsMax = GameObject.FindGameObjectsWithTag("fireDiamond").Length;
        
        WaterCounterDisplay();
        FireCounterDisplay();
        
    }

    public void WaterCounterUp()
    {
        _waterDiamondsCurrent++;
        WaterCounterDisplay();
        if (_waterDiamondsCurrent >= _waterDiamondsMax)
        {
            C_AlwaysThere.AllWaterDias = true;
            onWaterDiasCollected?.Invoke();
        }
    }
    
    private void WaterCounterDisplay()
    {
        _txtWaterCounter.text = _waterDiamondsCurrent.ToString() + "/" + _waterDiamondsMax.ToString();
    }
    
    public void FireCounterUp()
    {
        _fireDiamondsCurrent++;
        FireCounterDisplay();
        if (_fireDiamondsCurrent >= _fireDiamondsMax)
        {
            C_AlwaysThere.AllFireDias = true;
            onFireDiasCollected?.Invoke();
        }
    }
    
    private void FireCounterDisplay()
    {
        _txtFireCounter.text = _fireDiamondsCurrent.ToString() + "/" + _fireDiamondsMax.ToString();
    }
    


}