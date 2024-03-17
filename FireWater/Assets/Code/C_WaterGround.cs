using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_WaterGround : MonoBehaviour
{
    [SerializeField] private C_SwitchScreens switchScreens;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Fire")
        {
            switchScreens.OpenDead();
        }
    }
}
