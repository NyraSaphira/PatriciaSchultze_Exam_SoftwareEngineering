using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class C_TK_Playing : MonoBehaviour
{
    private Label _txtFireCounter;
    private Label _txtWaterCounter;

    private int _waterDiamondsMax;
    private int _fireDiamondsMax;
    
    private int _waterDiamondsCurrent;
    private int _fireDiamondsCurrent;

    [SerializeField] private C_DiamondWater diamondWater;
    [SerializeField] private C_DiamondFire diamondFire;
    
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
        if (_waterDiamondsCurrent >= _waterDiamondsMax) ; //Open Door
    }
    
    private void WaterCounterDisplay()
    {
        _txtWaterCounter.text = _waterDiamondsCurrent.ToString() + "/" + _waterDiamondsMax.ToString();
    }
    
    public void FireCounterUp()
    {
        _fireDiamondsCurrent++;
        FireCounterDisplay();
        if (_fireDiamondsCurrent >= _fireDiamondsMax) ; //Open Door
    }
    
    private void FireCounterDisplay()
    {
        _txtFireCounter.text = _fireDiamondsCurrent.ToString() + "/" + _fireDiamondsMax.ToString();
    }
    


}