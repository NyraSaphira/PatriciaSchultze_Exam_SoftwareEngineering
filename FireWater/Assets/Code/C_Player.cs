using UnityEngine;

public class C_Player : MonoBehaviour
{

    [SerializeField] private float speed = 8f;
    [SerializeField] private float jumpingPower = 37f;
    protected bool IsFacingRight = true;
    protected bool IsMovingRight;
    protected bool IsMovingLeft;
    protected bool IsAddingLeft;
    protected bool IsAddingRight;

    [SerializeField] private Rigidbody2D playerBody;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    
    protected void MoveUp()
    {
        if(IsGrounded()) playerBody.velocity = new Vector2(playerBody.velocity.x, jumpingPower);
        if(playerBody.velocity.y>0f) playerBody.velocity = new Vector2(playerBody.velocity.x, playerBody.velocity.y*0.5f);  //jumping higher
    }
    protected void MoveLeft()
    {
        IsMovingLeft = true;
        playerBody.velocity = new Vector2(-speed, playerBody.velocity.y);
        //playerBody.position = new Vector2(playerBody.position.x-speed, playerBody.position.y);
        if(IsFacingRight) Flip();
    }
    protected void MoveRight()
    {
        IsMovingRight = true;
        playerBody.velocity = new Vector2(speed, playerBody.velocity.y);
        //playerBody.position = new Vector2(playerBody.position.x+speed, playerBody.position.y);
        if(!IsFacingRight) Flip();
    }
    
    protected void StopMovingLeft()
    {
        IsMovingLeft = false;
        StopMoving();
    }
    protected void StopMovingRight()
    {
        IsMovingRight = false;
        StopMoving();
    }
    public void StopMoving()
    {
        playerBody.velocity = new Vector2(0, playerBody.velocity.y);
        if(!IsFacingRight) Flip();
    }
    

    private void Flip()
    {
        IsFacingRight = !IsFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    
}
