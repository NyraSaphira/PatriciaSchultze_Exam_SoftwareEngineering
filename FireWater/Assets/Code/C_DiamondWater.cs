using UnityEngine;

public class C_DiamondWater: MonoBehaviour
{
    [SerializeField] C_TK_Playing playing;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Water")
        {
            playing.WaterCounterUp();
            Destroy(this.gameObject);
        }
    }
}
