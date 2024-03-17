using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Fire : C_Player
{
    void Update()
    {
        if (!C_AlwaysThere.MovementStop)
        {
            //Movement
            if (Input.GetKeyDown(KeyCode.UpArrow)) MoveUp();
            if (Input.GetKey(KeyCode.LeftArrow)) MoveLeft();
            //itll always go right if both keys are pressed, unless you can only go right, while both are pressed, when the left one isnt added in the meantime
            if (Input.GetKey(KeyCode.RightArrow)) //wenn links gedrückt ist, rechts immer wieder, dann bestimmt das drücken / nicht drücken von rechts, wenn dann aber ohne links los zu lassen das gewechselt wird, kann rechts nicht mehr übernehmen, außer addedlinks wird auf false gesetzt, sobald der rechte los gelassen ist
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow)) isAddingLeft = true;
                if (!isAddingLeft) MoveRight();
            }

            if (Input.GetKeyUp(KeyCode.LeftArrow) || (!Input.GetKey(KeyCode.LeftArrow) || !Input.GetKey(KeyCode.RightArrow)))
                isAddingLeft = false; //resetting the stopping to move right, when left isnt pressed

            //StopMovement
            if (Input.GetKeyUp(KeyCode.LeftArrow) && isMovingRight) MoveRight(); //so that if you were keeping pressing both keys, and release the left, one, then go right again
            else if (!Input.GetKey(KeyCode.RightArrow) && isFacingRight) StopMovingRight(); //stop movement, if both right/left keys are removed
            if (Input.GetKeyUp(KeyCode.RightArrow) && isMovingLeft) MoveLeft();
            else if (!Input.GetKey(KeyCode.LeftArrow) && !isFacingRight) StopMovingLeft();
        }
        
    }
}
