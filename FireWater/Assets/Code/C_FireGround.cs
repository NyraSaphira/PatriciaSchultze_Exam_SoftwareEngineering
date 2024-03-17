using UnityEngine;

public class C_FireGround : MonoBehaviour
{
    [SerializeField] private C_SwitchScreens switchScreens;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Water")
        {
            switchScreens.OpenDead();
        }
    }
}
