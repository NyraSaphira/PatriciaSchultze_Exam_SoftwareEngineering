using UnityEngine;

public class C_PoisonGround : MonoBehaviour
{
    [SerializeField] private C_SwitchScreens switchScreens;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Fire" || other.gameObject.name == "Water")
        {
            switchScreens.OpenDead();
        }
    }
}
