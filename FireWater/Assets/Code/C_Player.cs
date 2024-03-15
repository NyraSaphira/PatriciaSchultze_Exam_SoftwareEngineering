using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class C_Player : MonoBehaviour
{

    private float speed = 8f;
    private float jumpingPower = 37f;
    public bool isFacingRight = true;
    public bool isMovingRight;
    public bool isMovingLeft;
    public bool isAddingLeft;
    public bool isAddingRight;

    [SerializeField] private Rigidbody2D playerBody;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    
    void Start()
    {
        
    }

    public void MoveUp()
    {
        if(isGrounded()) playerBody.velocity = new Vector2(playerBody.velocity.x, jumpingPower);
        if(playerBody.velocity.y>0f) playerBody.velocity = new Vector2(playerBody.velocity.x, playerBody.velocity.y*0.5f);  //jumping higher
    }
    public void MoveLeft()
    {
        isMovingLeft = true;
        playerBody.velocity = new Vector2(-speed, playerBody.velocity.y);
        //playerBody.position = new Vector2(playerBody.position.x-speed, playerBody.position.y);
        if(isFacingRight) Flip();
    }
    public void MoveRight()
    {
        isMovingRight = true;
        playerBody.velocity = new Vector2(speed, playerBody.velocity.y);
        //playerBody.position = new Vector2(playerBody.position.x+speed, playerBody.position.y);
        if(!isFacingRight) Flip();
    }
    
    public void StopMovingLeft()
    {
        isMovingLeft = false;
        StopMoving();
    }
    public void StopMovingRight()
    {
        isMovingRight = false;
        StopMoving();
    }
    void StopMoving()
    {
        playerBody.velocity = new Vector2(0, playerBody.velocity.y);
        //playerBody.position = new Vector2(playerBody.position.x+speed, playerBody.position.y);
        if(!isFacingRight) Flip();
    }
    

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    
}
