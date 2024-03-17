using UnityEngine;
using UnityEngine.UIElements;

public class C_TK_Start : MonoBehaviour
{
    private Button _butStart;

    [SerializeField] C_SwitchScreens switchScreens;
    
    void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        _butStart = root.Q<Button>("but_start");
        
        _butStart.clicked += StartGame;
    }

    private void StartGame()
    {
        switchScreens.OpenPlaying();
    }

}

