using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Water : C_Player
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) MoveUp();
        if (Input.GetKeyDown(KeyCode.A)) MoveLeft();
        if (Input.GetKeyDown(KeyCode.D)) MoveRight();
        
        if(Input.GetKeyUp(KeyCode.A) && isMovingRight) MoveRight(); //so that if you were keeping pressing both keys, and release the left, one, then go right again
        else if (!Input.GetKey(KeyCode.D) && isFacingRight) StopMovingRight(); //stop movement, if both right/left keys are removed
        if (Input.GetKeyUp(KeyCode.D) && isMovingLeft) MoveLeft();
        else if (!Input.GetKey(KeyCode.A) && !isFacingRight) StopMovingLeft();
        
    }
}
