using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class C_TK_Start : MonoBehaviour
{
    private Button _butStart;

    private C_SwitchScreens _switchScreens;
    
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        _butStart = root.Q<Button>("but_restart");
        
        _butStart.clicked += StartGame;
    }

    private void StartGame()
    {
        _switchScreens.OpenPlaying();
    }

}

