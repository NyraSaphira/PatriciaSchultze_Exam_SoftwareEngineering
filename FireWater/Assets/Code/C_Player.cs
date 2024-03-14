using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class C_Player : MonoBehaviour
{

    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;
    
    [SerializeField] private Rigidbody2D playerBody;
    
    
    void Start()
    {
        
    }

    void MoveUp()
    {
        playerBody.velocity = new Vector2(speed, playerBody.velocity.y);
    }
    void MoveLeft()
    {
        
    }
    void MoveRight()
    {
        
    }
    
    
}
