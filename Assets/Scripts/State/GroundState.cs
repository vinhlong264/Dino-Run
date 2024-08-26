using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundState : DinoState
{
    
    public GroundState(Dino _dino, DinoStateManager _stateManager) : base(_dino, _stateManager)
    {
    }

    public override void Enter()
    {

    }

    public override void Update()
    {
        if(!Dino.isGroundDetected() && Dino.canJump)
        {
            stateManager.changeState(Dino._jumpState);
            Dino.canJump = false;
            return;
        }


        if (Dino.isGroundDetected())
        {
            Dino.canJump = true;
        }
    }

    public override void Exit()
    {

    }


}