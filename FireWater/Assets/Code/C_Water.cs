using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Water : C_Player
{
    [SerializeField] C_TK_Dead_Finish deadFinish;
    void Start()
    {
        deadFinish.onDeath.AddListener(StopMoving); //onDeath.RemoveAllListeners //oder satt diese zeile im inspector
    }

    // Update is called once per frame
    void Update()
    {
        if (!C_AlwaysThere.MovementStop)
        {
            //Movement
            if (Input.GetKeyDown(KeyCode.W)) MoveUp();
            if (Input.GetKey(KeyCode.A)) MoveLeft();
            //itll always go right if both keys are pressed, unless you can only go right, while both are pressed, when the left one isnt added in the meantime
            if (Input.GetKey(KeyCode.D)) //wenn links gedrückt ist, rechts immer wieder, dann bestimmt das drücken / nicht drücken von rechts, wenn dann aber ohne links los zu lassen das gewechselt wird, kann rechts nicht mehr übernehmen, außer addedlinks wird auf false gesetzt, sobald der rechte los gelassen ist)
            {
                if (Input.GetKeyDown(KeyCode.A)) isAddingLeft = true;
                if (!isAddingLeft) MoveRight();
            }

            if (Input.GetKeyUp(KeyCode.A) || (!Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.D)))
                isAddingLeft = false; //resetting the stopping to move right, when left isnt pressed

            //StopMovement
            if (Input.GetKeyUp(KeyCode.A) && isMovingRight) MoveRight(); //so that if you were keeping pressing both keys, and release the left, one, then go right again
            else if (!Input.GetKey(KeyCode.D) && isFacingRight) StopMovingRight(); //stop movement, if both right/left keys are removed
            if (Input.GetKeyUp(KeyCode.D) && isMovingLeft) MoveLeft();
            else if (!Input.GetKey(KeyCode.A) && !isFacingRight) StopMovingLeft();
        }
        
    }
}
