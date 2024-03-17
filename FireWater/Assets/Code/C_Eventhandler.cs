using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Eventhandler : MonoBehaviour
{
    public delegate void MovementAction();

    public static event MovementAction StoppingEvent;
}
