using UnityEngine;
using UnityEngine.UIElements;

public class C_TK_Sure : MonoBehaviour
{
    private Button _butYes;
    private Button _butNo;

    [SerializeField] C_SwitchScreens switchScreens;
    
    void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        _butYes = root.Q<Button>("but_yes");
        _butNo = root.Q<Button>("but_no");
        
        _butNo.clicked += No;
        _butYes.clicked += Yes;
    }

    private void No()
    {
        switchScreens.CloseSure();
    }

    private void Yes()
    {
        Application.Quit();                              //for builds
        UnityEditor.EditorApplication.isPlaying = false; //for exiting play mode
    }



}