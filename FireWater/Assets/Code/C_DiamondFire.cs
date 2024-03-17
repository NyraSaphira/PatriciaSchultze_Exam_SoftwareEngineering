using UnityEngine;

public class C_DiamondFire : MonoBehaviour
{
    [SerializeField] C_TK_Playing playing;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Fire")
        {
            playing.FireCounterUp();
            Destroy(this.gameObject);
        }
    }
}
