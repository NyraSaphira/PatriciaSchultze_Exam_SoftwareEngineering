using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class C_Player : MonoBehaviour
{

    [SerializeField] private float speed = 8f;
    [SerializeField] private float jumpingPower = 37f;
    protected bool isFacingRight = true;
    protected bool isMovingRight;
    protected bool isMovingLeft;
    protected bool isAddingLeft;
    protected bool isAddingRight;

    [SerializeField] private Rigidbody2D playerBody;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    
    void Start()
    {
        
    }

    protected void MoveUp()
    {
        if(IsGrounded()) playerBody.velocity = new Vector2(playerBody.velocity.x, jumpingPower);
        if(playerBody.velocity.y>0f) playerBody.velocity = new Vector2(playerBody.velocity.x, playerBody.velocity.y*0.5f);  //jumping higher
    }
    protected void MoveLeft()
    {
        isMovingLeft = true;
        playerBody.velocity = new Vector2(-speed, playerBody.velocity.y);
        //playerBody.position = new Vector2(playerBody.position.x-speed, playerBody.position.y);
        if(isFacingRight) Flip();
    }
    protected void MoveRight()
    {
        isMovingRight = true;
        playerBody.velocity = new Vector2(speed, playerBody.velocity.y);
        //playerBody.position = new Vector2(playerBody.position.x+speed, playerBody.position.y);
        if(!isFacingRight) Flip();
    }
    
    protected void StopMovingLeft()
    {
        isMovingLeft = false;
        StopMoving();
    }
    protected void StopMovingRight()
    {
        isMovingRight = false;
        StopMoving();
    }
    public void StopMoving()
    {
        playerBody.velocity = new Vector2(0, playerBody.velocity.y);
        if(!isFacingRight) Flip();
    }
    

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    
}
