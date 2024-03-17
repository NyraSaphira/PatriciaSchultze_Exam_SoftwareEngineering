using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class C_TK_Sure : MonoBehaviour
{
    private Button _butYes;
    private Button _butNo;

    private C_SwitchScreens _switchScreens;
    
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        _butYes = root.Q<Button>("but_restart");
        _butNo = root.Q<Button>("but_quit");
        
        _butNo.clicked += No;
        _butYes.clicked += Yes;
    }

    private void No()
    {
        _switchScreens.CloseSure();
    }

    private void Yes()
    {
        Application.Quit();                              //for biulds
        UnityEditor.EditorApplication.isPlaying = false; //for exiting play mode
    }



}