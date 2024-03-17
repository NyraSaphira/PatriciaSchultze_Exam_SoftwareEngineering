using UnityEngine;
using UnityEngine.UIElements;

public class C_SwitchScreens : MonoBehaviour
{
    public static UIDocument ActiveDocument;

    [SerializeField] UIDocument tkDead;
    [SerializeField] UIDocument tkStart;
    [SerializeField] UIDocument tkSure;
    [SerializeField] UIDocument tkPlaying;
    [SerializeField] UIDocument tkFinish;

    private UIDocument _activeDocument;
    
    private bool _sureIsOpen;
    
    void Start()
    {
        
        tkDead.gameObject.SetActive(false);
        tkFinish.gameObject.SetActive(false);
        tkPlaying.gameObject.SetActive(false);
        tkSure.gameObject.SetActive(false);
        tkStart.gameObject.SetActive(true);

        _activeDocument = tkStart;
        OpenStart();
    }
    
    

    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Escape) && !_sureIsOpen)
        {
            OpenSure();
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            CloseSure();
        }

    }

    public void OpenSure()
    {
        _sureIsOpen = true;
        tkSure.gameObject.SetActive(true);
        MovementStop();
    } 
    
    public void CloseSure()
    {
        _sureIsOpen = false;
        tkSure.gameObject.SetActive(false);
    } 
    
    private void OpenStart()
    {
        _activeDocument.gameObject.SetActive(false);
        _activeDocument = tkStart;
        _activeDocument.gameObject.SetActive(true);
        MovementStop();
    } 
    
    public void OpenPlaying()
    {
        _activeDocument.gameObject.SetActive(false);
        _activeDocument = tkPlaying;
        _activeDocument.gameObject.SetActive(true);
        MovementStart();
    } 
    
    public void OpenFinish()
    {
        _activeDocument.gameObject.SetActive(false);
        _activeDocument = tkFinish;
        _activeDocument.gameObject.SetActive(true);
        MovementStop();
    } 
    
    public void OpenDead()
    {
        _activeDocument.gameObject.SetActive(false);
        _activeDocument = tkDead;
        _activeDocument.gameObject.SetActive(true);
        MovementStop();
    }

    private void MovementStop()
    {
        C_AlwaysThere.MovementStop = true;
    }
    
    private void MovementStart()
    {
        C_AlwaysThere.MovementStop = false;
    }
}