using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class C_TK_Dead_Finish : MonoBehaviour
{
    private Button _butRestart;
    private Button _butQuit;

    public UnityEvent onDeath;

   [SerializeField] C_SwitchScreens switchScreens;
    
    void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        _butRestart = root.Q<Button>("but_restart");
        _butQuit = root.Q<Button>("but_quit");
        
        _butQuit.clicked += Quit;
        _butRestart.clicked += Restart;

        onDeath?.Invoke();
    }

    private void Quit()
    {
        switchScreens.OpenSure();
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}
