using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class C_TK_Dead_Finish : MonoBehaviour
{
    private Button _butRestart;
    private Button _butQuit;

    private C_SwitchScreens _switchScreens;
    
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        _butRestart = root.Q<Button>("but_restart");
        _butQuit = root.Q<Button>("but_quit");
        
        _butQuit.clicked += Quit;
        _butRestart.clicked += Restart;
    }

    private void Quit()
    {
        _switchScreens.OpenSure();
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}
